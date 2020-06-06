using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.net_Core_Project.Data.Migrations
{
    public partial class ReservationModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservedFor",
                table: "Reservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "ForWhen",
                table: "Reservations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 5, 12, 9, 58, 31, 669, DateTimeKind.Utc).AddTicks(9495));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForWhen",
                table: "Reservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservedFor",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 5, 2, 1, 44, 47, 731, DateTimeKind.Utc).AddTicks(5397));
        }
    }
}
