#nullable disable

namespace Consumer.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    /// <inheritdoc />
    public partial class Init_data_point : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataPointTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precision = table.Column<int>(type: "int", nullable: false),
                    Scale = table.Column<double>(type: "float", nullable: true),
                    Offset = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPointTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataPointHistoryTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataPointId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPointHistoryTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPointHistoryTable_DataPointTable_DataPointId",
                        column: x => x.DataPointId,
                        principalTable: "DataPointTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataPointHistoryTable_DataPointId",
                table: "DataPointHistoryTable",
                column: "DataPointId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataPointHistoryTable");

            migrationBuilder.DropTable(
                name: "DataPointTable");
        }
    }
}
