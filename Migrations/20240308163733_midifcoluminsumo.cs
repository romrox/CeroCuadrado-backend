using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CeroCuadrado.Migrations
{
    /// <inheritdoc />
    public partial class midifcoluminsumo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnidadesName",
                table: "Insumos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnidadesName",
                table: "Insumos");
        }
    }
}
