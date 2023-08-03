// <copyright file="DataPointHistory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Api.Data.DTOs
{
    /// <summary>
    /// This class get data received from Kafka and convert to Database schema.
    /// </summary>
    public class ReadDataPointDto
    {
        /// <summary>
        /// Gets or Sets Representation of Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Representation of cost Name as string.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets Representation of Unit as string.
        /// </summary>
        public string? Unit { get; set; }

        /// <summary>
        /// Gets or Sets Representation of Scale as double.
        /// </summary>
        public double? Scale { get; set; }

        /// <summary>
        /// Gets or Sets Representation of Offset as double.
        /// </summary>
        public double? Offset { get; set; }
    }
}
