using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.net_Core_Project.Data.Migrations
{
    public partial class _00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 5, 17, 11, 51, 17, 211, DateTimeKind.Utc).AddTicks(6027));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 5, 12, 9, 58, 31, 669, DateTimeKind.Utc).AddTicks(9495));
        }
    }
}
