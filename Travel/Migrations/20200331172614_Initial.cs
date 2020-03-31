using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Author = table.Column<string>(maxLength: 20, nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "City", "Country", "Description", "Rating" },
                values: new object[,]
                {
                    { 1, "Author1", "Istanbul", "Turkey", "Istanbul is one of the truly great romantic cities; home to a layering of civilization on civilization, of empire built on empire", 5 },
                    { 2, "Author1", "Paris", "France", "Paris is regarded as one of the most dynamic cities in Europe, and for good reason: the city assaults the senses; demanding to be seen, heard, touched, tasted and smelled.", 4 },
                    { 3, "Author1", "Rome", "Italy", "An in depth vacation to one of the most enduring cities in Europe! Rome is the heart of Italy; once the center of the world`s greatest empire, the Eternal City has some of the finest art and architecture to survive from the last 2,000 years.", 5 },
                    { 4, "Author4", "Istanbul", "Turkey", "From the holy sites of Sultanahmet and the 19th-century European elegance of Beyoğlu to the high fashion of Nişantaşı, the vibrant café society of Kadıköy and the football-loving streets of Beşiktaş, it’s easy to see why travelers say that Istanbul isn’t just one city, but many cities within one.", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
