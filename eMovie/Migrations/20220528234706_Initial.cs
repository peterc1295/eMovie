using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovie.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
