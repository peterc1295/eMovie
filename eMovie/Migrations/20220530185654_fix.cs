using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovie.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 19, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9299), new DateTime(2022, 6, 2, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 28, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9295), new DateTime(2022, 5, 20, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9291), new DateTime(2022, 5, 20, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 6, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9287), new DateTime(2022, 5, 30, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 2, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9283), new DateTime(2022, 5, 30, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 9, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9278), new DateTime(2022, 5, 20, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9242) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 17, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2998), new DateTime(2022, 5, 31, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 26, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 5, 18, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 23, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2988), new DateTime(2022, 5, 18, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 4, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2984), new DateTime(2022, 5, 28, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 31, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2980), new DateTime(2022, 5, 28, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2975), new DateTime(2022, 5, 18, 16, 50, 32, 623, DateTimeKind.Local).AddTicks(2943) });
        }
    }
}
