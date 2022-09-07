using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class direciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "direcciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    calle = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    observasiones = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    numero = table.Column<long>(type: "bigint", nullable: false),
                    id_Persona = table.Column<int>(type: "int", nullable: false),
                    personasId_Persona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_direcciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_direcciones_Personas_personasId_Persona",
                        column: x => x.personasId_Persona,
                        principalTable: "Personas",
                        principalColumn: "Id_Persona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_direcciones_personasId_Persona",
                table: "direcciones",
                column: "personasId_Persona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "direcciones");
        }
    }
}
