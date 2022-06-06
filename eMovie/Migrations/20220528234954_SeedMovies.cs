using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovie.Migrations
{
    public partial class SeedMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate", "TheaterId" },
                values: new object[,]
                {
                    { -6, "This is the Cold Soles movie description", new DateTime(2022, 6, 17, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6783), "http://dotnethow.net/images/movies/movie-8.jpeg", 2, "Cold Soles", 39.5, -5, new DateTime(2022, 5, 31, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6781), -1 },
                    { -5, "This is the Scoob movie description", new DateTime(2022, 5, 26, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6778), "http://dotnethow.net/images/movies/movie-7.jpeg", 4, "Scoob", 39.5, -3, new DateTime(2022, 5, 18, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6777), -1 },
                    { -4, "This is the Race movie description", new DateTime(2022, 5, 23, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6774), "http://dotnethow.net/images/movies/movie-6.jpeg", 0, "Race", 39.5, -2, new DateTime(2022, 5, 18, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6773), -1 },
                    { -3, "This is the Ghost movie description", new DateTime(2022, 6, 4, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6770), "http://dotnethow.net/images/movies/movie-4.jpeg", 5, "Ghost", 39.5, -4, new DateTime(2022, 5, 28, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6769), -4 },
                    { -2, "This is the Shawshank Redemption description", new DateTime(2022, 5, 31, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6766), "http://dotnethow.net/images/movies/movie-1.jpeg", 5, "The Shawshank Redemption", 29.5, -1, new DateTime(2022, 5, 28, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6765), -1 },
                    { -1, "This is the Life movie description", new DateTime(2022, 6, 7, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6761), "http://dotnethow.net/images/movies/movie-3.jpeg", 3, "Life", 39.5, -3, new DateTime(2022, 5, 18, 16, 49, 53, 871, DateTimeKind.Local).AddTicks(6724), -3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: -1);
        }
    }
}
