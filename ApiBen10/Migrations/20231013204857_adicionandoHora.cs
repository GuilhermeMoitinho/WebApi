using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Ben10.Migrations
{
    /// <inheritdoc />
    public partial class adicionandoHora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HorarioDeCadastro",
                table: "Aliens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorarioDeCadastro",
                table: "Aliens");
        }
    }
}
