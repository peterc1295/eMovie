using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovie.Migrations
{
    public partial class SeedActorMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { -5, -6 },
                    { -5, -5 },
                    { -5, -3 },
                    { -4, -6 },
                    { -4, -5 },
                    { -4, -4 },
                    { -4, -2 },
                    { -3, -6 },
                    { -3, -5 },
                    { -3, -4 },
                    { -3, -1 },
                    { -2, -5 },
                    { -2, -4 },
                    { -2, -3 },
                    { -1, -3 },
                    { -1, -2 },
                    { -1, -1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -5, -6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -5, -5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -5, -3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -4, -6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -4, -5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -4, -4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -4, -2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -3, -6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -3, -5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -3, -4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -3, -1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -2, -5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -2, -4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -2, -3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -1, -3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -1, -2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { -1, -1 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 17, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6783), new DateTime(2022, 5, 31, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 26, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6778), new DateTime(2022, 5, 18, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 23, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6774), new DateTime(2022, 5, 18, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 4, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 5, 28, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 31, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6766), new DateTime(2022, 5, 28, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6761), new DateTime(2022, 5, 18, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6724) });
        }
    }
}
