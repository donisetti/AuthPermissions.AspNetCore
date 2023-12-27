using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facil.Infra.Data.Migrations
{
    public partial class revisaoCamposExtras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Appointments");
        }
    }
}
