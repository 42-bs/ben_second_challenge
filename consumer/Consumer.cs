﻿// <copyright file="Consumer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Consumer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Confluent.Kafka;
    using DotNetEnv;
    using Newtonsoft.Json;

    /// <summary>
    /// Consume from kafka and send to the database.
    /// </summary>
    public class Consumer
    {
        /// <summary>
        /// This main aims to read from a single topic and add to a single table in the database,
        /// the goal is just to fill the database with lots of information.
        /// </summary>
        /// <returns>Represents an asynchonous task operation.</returns>
        public static async Task Main()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Env.Load();
            var config = new ConsumerConfig
            {
                GroupId = "consumer-group-1",
                BootstrapServers = Env.GetString("KAFKA_HOST"),
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, DataPointHistory>(config).
                SetValueDeserializer(new DataPointHistoryDeserializer()).Build();
            {
                consumer.Subscribe("random_data_point");

                var cancellationTokenSource = new CancellationTokenSource();
                Console.CancelKeyPress += (_, e) =>
                {
                    e.Cancel = true;
                    cancellationTokenSource.Cancel();
                };

                try
                {
                    while (true)
                    {
                        try
                        {
                            var consumerResult = consumer.Consume(cancellationTokenSource.Token);
                            var message = consumerResult.Message;

                            using (var db = new DataPointDbContext())
                            {
                                DataPointHistory dataPointHistory = message.Value;
                                db.DataPointHistoryTable.Add(dataPointHistory);
                                db.SaveChanges();
                            }
                        }
                        catch (ConsumeException e)
                        {
                            Console.WriteLine($"Error occured: {e.Error.Reason}");
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    consumer.Close();
                }
            }
        }
    }
}
