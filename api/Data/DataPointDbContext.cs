// <copyright file="DataPointDbContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Api.Data
{
    using DotNetEnv;
    using Microsoft.EntityFrameworkCore;
    using Api.Models;

    /// <summary>
    /// Define the context of the database and the table for DataPointHistory model and specify the db provider configuration.
    /// </summary>
    internal class DataPointDbContext : DbContext
    {
        /// <summary>
        /// Gets or Sets Representation of DataPointHistory Entity.
        /// </summary>
        public DbSet<DataPointHistory> DataPointHistoryTable { get; set; }

        /// <summary>
        /// Gets or Sets Representation of DataPoint Entity.
        /// </summary>
        public DbSet<DataPoint> DataPointTable { get; set; }

        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=" +
                        Env.GetString("DB_SERVER") +
                        ";Database=Ben; User Id=" +
                        Env.GetString("DB_USER") +
                        "; Password=" +
                        Env.GetString("DB_PASS") +
                        ";TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataPointHistory>()
				.HasOne(e => e.DataPoint)
				.WithMany(e => e.DataPointHistorys)
				.HasForeignKey(e => e.DataPointId)
				.HasPrincipalKey(e => e.Id)
				.IsRequired();
                // .HasMany(e => e.DataPointHistorys)
                // .WithOne(e => e.DataPoint)
                // .HasForeignKey(e => e.DataPointId)
                // .HasPrincipalKey(e => e.Id);
        }
    }
}
