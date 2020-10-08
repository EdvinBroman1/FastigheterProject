using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamRedWebApi.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2020, 10, 8, 18, 0, 1, 148, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 8, 18, 0, 1, 143, DateTimeKind.Unspecified).AddTicks(5859), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 8, 18, 0, 1, 147, DateTimeKind.Unspecified).AddTicks(7811), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 8, 18, 0, 1, 147, DateTimeKind.Unspecified).AddTicks(7982), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 8, 18, 0, 1, 147, DateTimeKind.Unspecified).AddTicks(7996), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 8, 18, 0, 1, 147, DateTimeKind.Unspecified).AddTicks(8004), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 8, 18, 0, 1, 147, DateTimeKind.Unspecified).AddTicks(8012), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 7,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 8, 18, 0, 1, 147, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 2, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 876, DateTimeKind.Unspecified).AddTicks(550), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(30), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(135), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(144), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(150), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(156), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 7,
                column: "AdCreated",
                value: new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(162), new TimeSpan(0, 2, 0, 0, 0)));
        }
    }
}
