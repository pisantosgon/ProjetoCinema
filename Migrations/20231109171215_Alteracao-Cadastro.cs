using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoCinema.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoCadastro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EscolhaFilme",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "HrSessao",
                table: "Cadastro");

            migrationBuilder.AddColumn<int>(
                name: "FilmeId",
                table: "Cadastro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_FilmeId",
                table: "Cadastro",
                column: "FilmeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cadastro_Filme_FilmeId",
                table: "Cadastro",
                column: "FilmeId",
                principalTable: "Filme",
                principalColumn: "FilmesId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cadastro_Filme_FilmeId",
                table: "Cadastro");

            migrationBuilder.DropIndex(
                name: "IX_Cadastro_FilmeId",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "FilmeId",
                table: "Cadastro");

            migrationBuilder.AddColumn<string>(
                name: "EscolhaFilme",
                table: "Cadastro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "HrSessao",
                table: "Cadastro",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
