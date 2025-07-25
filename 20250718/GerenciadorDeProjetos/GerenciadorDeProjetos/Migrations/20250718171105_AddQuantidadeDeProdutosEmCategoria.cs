﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeProjetos.Migrations
{
    /// <inheritdoc />
    public partial class AddQuantidadeDeProdutosEmCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantidadeProdutos",
                table: "Categorias",
                newName: "QuantidadeDeProdutos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantidadeDeProdutos",
                table: "Categorias",
                newName: "QuantidadeProdutos");
        }
    }
}
