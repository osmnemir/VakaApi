using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VakaApplication.Migrations
{
    /// <inheritdoc />
    public partial class İnitialMigrationn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DailyWorkedDays",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "OvertimeHours",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyWorkedDays",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OvertimeHours",
                table: "Employees");
        }
    }
}
