using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CeroCuadrado.Migrations
{
    /// <inheritdoc />
    public partial class cambios2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "TipoDeComprobantes");

            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "Empresas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "TipoDeComprobantes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "Proveedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
