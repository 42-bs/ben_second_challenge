// <copyright file="DataPoint.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Api.Models
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
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Representation of name as string.
        /// </summary>
        [Required]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets Representation of measure unit as string.
        /// </summary>
        [Required]
        public string? Unit { get; set; }

        /// <summary>
        /// Gets or Sets Representation of precision as int.
        /// </summary>
        [Required]
        public int Precision { get; set; }

        /// <summary>
        /// Gets or Sets Representation of scale as double.
        /// </summary>
        [Required]
        public double? Scale { get; set; }

        /// <summary>
        /// Gets or Sets Representation of offset as double.
        /// </summary>
        [Required]
        public double? Offset { get; set; }

        /// <summary>
        /// Gets Representation of DataPointHistorys as ICollection.
        /// </summary>
        public virtual ICollection<DataPointHistory> DataPointHistorys { get; set; }
    }
}
