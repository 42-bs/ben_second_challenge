// <copyright file="DataPointDbContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Api.Data
{
    using DotNetEnv;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Api.Models;

    /// <summary>
    /// Define the context of the database and the table for DataPointHistory model and specify the db provider configuration.
    /// </summary>
    public class DataPointDbContext : IdentityDbContext<User>
    {
        private readonly IConfiguration _configuration;
        public DataPointDbContext(DbContextOptions<DataPointDbContext> options, IConfiguration configuration): base(options)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Gets or Sets Representation of DataPointHistory Entity.
        /// </summary>
        public DbSet<DataPointHistory> DataPointHistoryTable { get; set; }

        /// <summary>
        /// Gets or Sets Representation of DataPoint Entity.
        /// </summary>
        public DbSet<DataPoint> DataPointTable { get; set; }

        //public DbSet<User> UserTable { get; set; }

        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:UserConnection"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
