using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country" },
                values: new object[] { 1, "Istanbul", "Turkey" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country" },
                values: new object[] { 2, "Paris", "France" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country" },
                values: new object[] { 3, "Rome", "Italy" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "Description", "DestinationId", "Rating" },
                values: new object[] { 1, "Author1", "Istanbul is one of the truly great romantic cities; home to a layering of civilization on civilization, of empire built on empire", 1, 5 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "Description", "DestinationId", "Rating" },
                values: new object[] { 2, "Author1", "Paris is regarded as one of the most dynamic cities in Europe, and for good reason: the city assaults the senses; demanding to be seen, heard, touched, tasted and smelled.", 2, 4 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "Description", "DestinationId", "Rating" },
                values: new object[] { 3, "Author1", "An in depth vacation to one of the most enduring cities in Europe! Rome is the heart of Italy; once the center of the world`s greatest empire, the Eternal City has some of the finest art and architecture to survive from the last 2,000 years.", 3, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);
        }
    }
}
