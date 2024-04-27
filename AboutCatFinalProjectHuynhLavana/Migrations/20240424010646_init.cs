using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AboutCatFinalProjectHuynhLavana.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cat",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CatBreed = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CatFavoriteFood = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CatFavoriteToy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Advice = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat", x => x.CatId);
                });

            migrationBuilder.InsertData(
                table: "Cat",
                columns: new[] { "CatId", "Advice", "CatBreed", "CatFavoriteFood", "CatFavoriteToy", "CatName" },
                values: new object[] { 1, "ho", "T", "c", "t", "Casablanca" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cat");
        }
    }
}
