using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class AddTableVenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataVenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.VendaId);
                });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "DataCadastro", "VendaId" },
                values: new object[] { new DateTime(2025, 7, 14, 15, 41, 4, 898, DateTimeKind.Local).AddTicks(1031), null });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "DataCadastro", "VendaId" },
                values: new object[] { new DateTime(2025, 7, 14, 15, 41, 4, 898, DateTimeKind.Local).AddTicks(1041), null });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "DataCadastro", "VendaId" },
                values: new object[] { new DateTime(2025, 7, 14, 15, 41, 4, 898, DateTimeKind.Local).AddTicks(1046), null });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_VendaId",
                table: "Produtos",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Vendas_VendaId",
                table: "Produtos",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Vendas_VendaId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_VendaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Produtos");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2025, 7, 14, 13, 48, 9, 988, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2025, 7, 14, 13, 48, 9, 988, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2025, 7, 14, 13, 48, 9, 988, DateTimeKind.Local).AddTicks(8535));
        }
    }
}
