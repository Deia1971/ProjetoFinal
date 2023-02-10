using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitoriaAgentes.Migrations
{
    public partial class monitoria3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descrição",
                table: "Monitoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrição",
                table: "Monitoria");
        }
    }
}
