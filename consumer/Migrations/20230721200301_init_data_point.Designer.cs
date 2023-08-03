﻿// <auto-generated />
using System;
using Consumer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Consumer.Migrations
{
    [DbContext(typeof(DataPointDbContext))]
    [Migration("20230721200301_Init_data_point")]
    partial class Init_data_point
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Consumer.DataPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Offset")
                        .HasColumnType("float");

                    b.Property<int>("Precision")
                        .HasColumnType("int");

                    b.Property<double?>("Scale")
                        .HasColumnType("float");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataPointTable");
                });

            modelBuilder.Entity("Consumer.DataPointHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DataPointId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DataPointId");

                    b.ToTable("DataPointHistoryTable");
                });

            modelBuilder.Entity("Consumer.DataPointHistory", b =>
                {
                    b.HasOne("Consumer.DataPoint", "DataPoint")
                        .WithMany("DataPointHistorys")
                        .HasForeignKey("DataPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataPoint");
                });

            modelBuilder.Entity("Consumer.DataPoint", b =>
                {
                    b.Navigation("DataPointHistorys");
                });
#pragma warning restore 612, 618
        }
    }
}
