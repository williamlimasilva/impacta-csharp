using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableVenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2025, 7, 14, 15, 43, 0, 993, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2025, 7, 14, 15, 43, 0, 993, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2025, 7, 14, 15, 43, 0, 993, DateTimeKind.Local).AddTicks(3771));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2025, 7, 14, 15, 41, 4, 898, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2025, 7, 14, 15, 41, 4, 898, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2025, 7, 14, 15, 41, 4, 898, DateTimeKind.Local).AddTicks(1046));
        }
    }
}
