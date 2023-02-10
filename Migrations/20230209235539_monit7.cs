using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitoriaAgentes.Migrations
{
    public partial class monit7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descrição",
                table: "Monitoria",
                newName: "Descricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Monitoria",
                newName: "Descrição");
        }
    }
}
