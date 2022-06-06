using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovie.Migrations
{
    public partial class QuantityNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 23, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2135), new DateTime(2022, 6, 6, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 1, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2130), new DateTime(2022, 5, 24, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 29, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2126), new DateTime(2022, 5, 24, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 10, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2122), new DateTime(2022, 6, 3, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 6, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2118), new DateTime(2022, 6, 3, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 13, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2113), new DateTime(2022, 5, 24, 19, 50, 27, 77, DateTimeKind.Local).AddTicks(2076) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 23, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2608), new DateTime(2022, 6, 6, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 1, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2604), new DateTime(2022, 5, 24, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 29, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2600), new DateTime(2022, 5, 24, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 10, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2595), new DateTime(2022, 6, 3, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 6, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2591), new DateTime(2022, 6, 3, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 13, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2586), new DateTime(2022, 5, 24, 19, 39, 55, 587, DateTimeKind.Local).AddTicks(2552) });
        }
    }
}
