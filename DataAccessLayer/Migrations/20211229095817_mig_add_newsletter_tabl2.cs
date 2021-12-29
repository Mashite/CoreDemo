using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_newsletter_tabl2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsLater",
                table: "NewsLater");

            migrationBuilder.RenameTable(
                name: "NewsLater",
                newName: "NewsLatter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsLatter",
                table: "NewsLatter",
                column: "MailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsLatter",
                table: "NewsLatter");

            migrationBuilder.RenameTable(
                name: "NewsLatter",
                newName: "NewsLater");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsLater",
                table: "NewsLater",
                column: "MailId");
        }
    }
}
