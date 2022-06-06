using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovie.Migrations
{
    public partial class SeedTheaters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "TheaterId",
                keyValue: -5);

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
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "TheaterId",
                keyValue: -1);
        }
    }
}
