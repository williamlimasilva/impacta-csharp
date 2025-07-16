using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaApp.Migrations
{
    /// <inheritdoc />
    public partial class AddAgendamentosTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    AgendamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Especialidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Medico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataHoraConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoAtendimento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.AgendamentoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");
        }
    }
}
