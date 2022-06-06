using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovie.Migrations
{
    public partial class UpdateId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TheaterId",
                table: "Theaters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Producers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 20, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8449), new DateTime(2022, 6, 3, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 29, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8444), new DateTime(2022, 5, 21, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 26, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 5, 21, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 7, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8436), new DateTime(2022, 5, 31, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 3, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8432), new DateTime(2022, 5, 31, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 10, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8427), new DateTime(2022, 5, 21, 7, 24, 57, 233, DateTimeKind.Local).AddTicks(8392) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Theaters",
                newName: "TheaterId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Producers",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actors",
                newName: "ActorId");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 19, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 6, 2, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(503), new DateTime(2022, 5, 20, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(499), new DateTime(2022, 5, 20, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 6, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(495), new DateTime(2022, 5, 30, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 2, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(491), new DateTime(2022, 5, 30, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 9, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(486), new DateTime(2022, 5, 20, 14, 13, 58, 170, DateTimeKind.Local).AddTicks(445) });
        }
    }
}
