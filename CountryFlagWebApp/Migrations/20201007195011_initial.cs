using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryFlagWebApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GameID = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "winter", "Winter Olympics" },
                    { "summer", "Summer Olympics" },
                    { "paralympics", "Paralympics" },
                    { "youth", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "GameID", "LogoImage", "Name" },
                values: new object[,]
                {
                    { "can", "indoor", "winter", "Canada.png", "Canada" },
                    { "por", "outdoor", "youth", "Portugal.png", "Portugal" },
                    { "fra", "indoor", "youth", "France.png", "France" },
                    { "fin", "outdoor", "youth", "Finland.png", "Finland" },
                    { "cyp", "indoor", "youth", "Cyprus.png", "Cyprus" },
                    { "zim", "outdoor", "paralympics", "Zimbabwe.png", "Zimbabwe" },
                    { "uru", "indoor", "paralympics", "Uruguay.png", "Uruguay" },
                    { "ukr", "indoor", "paralympics", "Ukraine.png", "Ukraine" },
                    { "tha", "indoor", "paralympics", "Thailand.png", "Thailand" },
                    { "pak", "outdoor", "paralympics", "Pakistan.png", "Pakistan" },
                    { "aus", "outdoor", "paralympics", "Austria.png", "Austria" },
                    { "usa", "outdoor", "summer", "USA.png", "USA" },
                    { "net", "outdoor", "summer", "Netherlands.png", "Netherlands" },
                    { "mex", "indoor", "summer", "Mexico.png", "Mexico" },
                    { "ger", "indoor", "summer", "Germany.png", "Germany" },
                    { "chi", "indoor", "summer", "China.png", "China" },
                    { "braz", "outdoor", "summer", "Brazil.png", "Brazil" },
                    { "swe", "indoor", "winter", "Sweden.png", "Sweden" },
                    { "jap", "outdoor", "winter", "Japan.png", "Japan" },
                    { "jam", "outdoor", "winter", "Jamaica.png", "Jamaica" },
                    { "ita", "outdoor", "winter", "Italy.png", "Italy" },
                    { "gb", "indoor", "winter", "GreatBritain.png", "Great Britain" },
                    { "rus", "indoor", "youth", "Russia.png", "Russia" },
                    { "slo", "outdoor", "youth", "Slovakia.png", "Slovakia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryID",
                table: "Countries",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
