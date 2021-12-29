using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_newsletter_tabl3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsLatter",
                table: "NewsLatter");

            migrationBuilder.RenameTable(
                name: "NewsLatter",
                newName: "NewsLetter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsLetter",
                table: "NewsLetter",
                column: "MailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsLetter",
                table: "NewsLetter");

            migrationBuilder.RenameTable(
                name: "NewsLetter",
                newName: "NewsLatter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsLatter",
                table: "NewsLatter",
                column: "MailId");
        }
    }
}
