// <copyright file="DataPointHistoryDeserializer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Consumer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Confluent.Kafka;
    using Newtonsoft.Json;

#nullable disable

    /// <summary>
    /// Custom deserializer class for consumer.
    /// </summary>
    public class DataPointHistoryDeserializer : IDeserializer<DataPointHistory>
    {
        /// <summary>
        /// Deserialize from json to dict, and from dict to DataPointHistory.
        /// </summary>
        /// <param name="data">ReadOnly representation of the data read from kafka.</param>
        /// <param name="isNull">Check if the data is null.</param>
        /// <param name="context">The relevant context about the serialization.</param>
        /// <returns>An DataPointHistory Object, ready to be send as model to database.</returns>
        public DataPointHistory Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
        {
            if (isNull)
            {
                return null;
            }

            var jsonString = Encoding.UTF8.GetString(data).Trim('"').Replace("\\\"", "\"");
            Console.WriteLine(jsonString);
            Dictionary<string, object> dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);
            DataPointHistory dataPointHistory = new DataPointHistory()
            {
                DataPointId = int.Parse(dict["dataPointId"].ToString()),
                Value = double.Parse(dict["value"].ToString()),
                Date = DateTime.Parse(dict["date"].ToString()),
				Status = dict["status"].ToString()
            };
            return dataPointHistory;
        }
    }
}
