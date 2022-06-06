using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovie.Migrations
{
    public partial class FixErrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "TheaterId",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "TheaterId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: -1);

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

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "TheaterId",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "TheaterId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "TheaterId",
                keyValue: -1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Bio", "FullName", "ProfilePicture" },
                values: new object[,]
                {
                    { -5, "This is the Bio of the second actor", "Actor 5", "http://dotnethow.net/images/actors/actor-5.jpeg" },
                    { -4, "This is the Bio of the second actor", "Actor 4", "http://dotnethow.net/images/actors/actor-4.jpeg" },
                    { -3, "This is the Bio of the second actor", "Actor 3", "http://dotnethow.net/images/actors/actor-3.jpeg" },
                    { -2, "This is the Bio of the second actor", "Actor 2", "http://dotnethow.net/images/actors/actor-2.jpeg" },
                    { -1, "This is the Bio of the first actor", "Actor 1", "http://dotnethow.net/images/actors/actor-1.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ProducerId", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { -5, "This is the Bio of the second actor", "Producer 5", "http://dotnethow.net/images/producers/producer-5.jpeg" },
                    { -4, "This is the Bio of the second actor", "Producer 4", "http://dotnethow.net/images/producers/producer-4.jpeg" },
                    { -3, "This is the Bio of the second actor", "Producer 3", "http://dotnethow.net/images/producers/producer-3.jpeg" },
                    { -2, "This is the Bio of the second actor", "Producer 2", "http://dotnethow.net/images/producers/producer-2.jpeg" },
                    { -1, "This is the Bio of the first actor", "Producer 1", "http://dotnethow.net/images/producers/producer-1.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Theaters",
                columns: new[] { "TheaterId", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { -5, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-5.jpeg", "Theaters 5" },
                    { -4, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-4.jpeg", "Theater 4" },
                    { -3, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-3.jpeg", "Theater 3" },
                    { -2, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-2.jpeg", "Theater 2" },
                    { -1, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-1.jpeg", "Theater 1" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate", "TheaterId" },
                values: new object[,]
                {
                    { -6, "This is the Cold Soles movie description", new DateTime(2022, 6, 19, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9299), "http://dotnethow.net/images/movies/movie-8.jpeg", 2, "Cold Soles", 39.5, -5, new DateTime(2022, 6, 2, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9297), -1 },
                    { -5, "This is the Scoob movie description", new DateTime(2022, 5, 28, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9295), "http://dotnethow.net/images/movies/movie-7.jpeg", 4, "Scoob", 39.5, -3, new DateTime(2022, 5, 20, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9293), -1 },
                    { -4, "This is the Race movie description", new DateTime(2022, 5, 25, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9291), "http://dotnethow.net/images/movies/movie-6.jpeg", 0, "Race", 39.5, -2, new DateTime(2022, 5, 20, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9289), -1 },
                    { -3, "This is the Ghost movie description", new DateTime(2022, 6, 6, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9287), "http://dotnethow.net/images/movies/movie-4.jpeg", 5, "Ghost", 39.5, -4, new DateTime(2022, 5, 30, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9285), -4 },
                    { -2, "This is the Shawshank Redemption description", new DateTime(2022, 6, 2, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9283), "http://dotnethow.net/images/movies/movie-1.jpeg", 5, "The Shawshank Redemption", 29.5, -1, new DateTime(2022, 5, 30, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9281), -1 },
                    { -1, "This is the Life movie description", new DateTime(2022, 6, 9, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9278), "http://dotnethow.net/images/movies/movie-3.jpeg", 3, "Life", 39.5, -3, new DateTime(2022, 5, 20, 11, 56, 54, 208, DateTimeKind.Local).AddTicks(9242), -3 }
                });

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
        }
    }
}
