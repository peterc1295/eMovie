using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovie.Migrations
{
    public partial class SeedProducers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
