using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace jbchorg.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asociado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    APaterno = table.Column<string>(nullable: true),
                    AMaterno = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: false),
                    TAsociado = table.Column<string>(nullable: true),
                    GAcademico = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asociado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensaje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Correo = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    APaterno = table.Column<string>(nullable: true),
                    AMaterno = table.Column<string>(nullable: true),
                    Movil = table.Column<string>(nullable: true),
                    Asunto = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensaje", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asociado");

            migrationBuilder.DropTable(
                name: "Mensaje");
        }
    }
}
