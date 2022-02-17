using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migaddblogRatingtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogRatings",
                columns: table => new
                {
                    BlogRationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    BlogTotalScore = table.Column<int>(type: "int", nullable: false),
                    BlogRatingCount = table.Column<int>(type: "int", nullable: false),
                    BlogAvarageScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogRatings", x => x.BlogRationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogRatings");
        }
    }
}
