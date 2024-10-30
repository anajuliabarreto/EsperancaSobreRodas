using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EsperancaSobreRodasAPI.Migrations
{
    /// <inheritdoc />
    public partial class MotoristaModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPlaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeMotorista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenhaMotorista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefoneMotorista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDocumentoMotorista = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoristas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motoristas");
        }
    }
}
