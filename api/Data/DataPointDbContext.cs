// <copyright file="DataPointDbContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Api.Data
{
    using Api.Models;
    using DotNetEnv;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Define the context of the database and the table for DataPointHistory model and specify the db provider configuration.
    /// </summary>
    public class DataPointDbContext : IdentityDbContext<User>
    {
        private readonly IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointDbContext"/> class.
        /// </summary>
        /// <param name="options">Contains the configuration options which are going to be used by the DbContext.</param>
        /// <param name="configuration">Contains the configuration options for the application.</param>
        public DataPointDbContext(DbContextOptions<DataPointDbContext> options, IConfiguration configuration)
            : base(options)
        {
            this.configuration = configuration;
        }

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
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:UserConnection"]);
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
