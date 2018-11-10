using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace jbchorg.Migrations
{
    public partial class fin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Correo = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    APaterno = table.Column<string>(nullable: false),
                    AMaterno = table.Column<string>(nullable: false),
                    DNI = table.Column<string>(nullable: false),
                    Movil = table.Column<string>(nullable: false),
                    Monto = table.Column<string>(nullable: false),
                    Banco = table.Column<string>(nullable: false),
                    Tarjeta = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donacion", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Duracion = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreServ = table.Column<string>(maxLength: 40, nullable: false),
                    tipo = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TAsociados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAsociados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asociados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    APaterno = table.Column<string>(nullable: true),
                    AMaterno = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Genero = table.Column<string>(nullable: true),
                    GAcademico = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    TAsociadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asociados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asociados_TAsociados_TAsociadoId",
                        column: x => x.TAsociadoId,
                        principalTable: "TAsociados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TAsociados",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Principal" });

            migrationBuilder.InsertData(
                table: "TAsociados",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Adjunto" });

            migrationBuilder.InsertData(
                table: "TAsociados",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Invitado" });

            migrationBuilder.CreateIndex(
                name: "IX_Asociados_TAsociadoId",
                table: "Asociados",
                column: "TAsociadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asociados");

            migrationBuilder.DropTable(
                name: "Donacion");

            migrationBuilder.DropTable(
                name: "Mensaje");

            migrationBuilder.DropTable(
                name: "Proyecto");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "TAsociados");
        }
    }
}
