// <copyright file="DataPoint.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Consumer
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;

    /// <summary>
    /// This class get data received from Kafka and convert to Database schema.
    /// </summary>
    public class DataPoint
    {
        /// <summary>
        /// Gets or Sets Representation of id as int.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Representation of name as string.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets Representation of measure unit as string.
        /// </summary>
        public string? Unit { get; set; }

        /// <summary>
        /// Gets or Sets Representation of precision as int.
        /// </summary>
        public int Precision { get; set; }

        /// <summary>
        /// Gets or Sets Representation of scale as double.
        /// </summary>
        public double? Scale { get; set; }

        /// <summary>
        /// Gets or Sets Representation of offset as double.
        /// </summary>
        public double? Offset { get; set; }

        /// <summary>
        /// Gets Representation of DataPointHistorys as ICollection.
        /// </summary>
        public ICollection<DataPointHistory> DataPointHistorys { get; } = new List<DataPointHistory>();
    }
}
