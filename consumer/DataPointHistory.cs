// <copyright file="DataPointHistory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Consumer
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// This class get data received from Kafka and convert to Database schema.
    /// </summary>
    public class DataPointHistory
    {
        /// <summary>
        /// Gets or Sets Representation of Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Representation of cost Value as double.
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Gets or Sets Representation of date as DateTime.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Representation of date as string.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or Sets Representation of CompanyID as int.
        /// </summary>
        public int DataPointId { get; set; }

        /// <summary>
        /// Gets or Sets Representation of DataPoint as DataPoint.
        /// </summary>
        public DataPoint DataPoint { get; set; }
    }
}
