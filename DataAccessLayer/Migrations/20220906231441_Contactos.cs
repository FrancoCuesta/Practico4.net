using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Contactos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposdeContactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposdeContactos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contactos",
                columns: table => new
                {
                    id_Contactos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TelefonoLinea = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Mobil = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    PersonasId_Persona = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactos", x => x.id_Contactos);
                    table.ForeignKey(
                        name: "FK_contactos_Personas_PersonasId_Persona",
                        column: x => x.PersonasId_Persona,
                        principalTable: "Personas",
                        principalColumn: "Id_Persona");
                    table.ForeignKey(
                        name: "FK_contactos_TiposdeContactos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposdeContactos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contactos_PersonasId_Persona",
                table: "contactos",
                column: "PersonasId_Persona");

            migrationBuilder.CreateIndex(
                name: "IX_contactos_TipoId",
                table: "contactos",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contactos");

            migrationBuilder.DropTable(
                name: "TiposdeContactos");
        }
    }
}
