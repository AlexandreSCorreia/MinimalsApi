using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace minimal_api.Migrations
{
    /// <inheritdoc />
    public partial class VeiculoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_administradors",
                table: "administradors");

            migrationBuilder.RenameTable(
                name: "administradors",
                newName: "Administradors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administradors",
                table: "Administradors",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administradors",
                table: "Administradors");

            migrationBuilder.RenameTable(
                name: "Administradors",
                newName: "administradors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_administradors",
                table: "administradors",
                column: "Id");
        }
    }
}
