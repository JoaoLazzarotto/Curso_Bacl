using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuProjetoApi.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTabelaPrevisaoTempo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrevisaoTempo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    DataBusca = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeCidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomePais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoCeu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SensacaoTermicaCelsius = table.Column<double>(type: "float", nullable: true),
                    Pressao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Humidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NascerDoSol = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PorDoSol = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TemperaturaAtualCelsius = table.Column<double>(type: "float", nullable: true),
                    TemperaturaMinimaCelsius = table.Column<double>(type: "float", nullable: true),
                    TemperaturaMaximaCelsius = table.Column<double>(type: "float", nullable: true),
                    VelocidadeKMH = table.Column<double>(type: "float", nullable: true),
                    Graus = table.Column<double>(type: "float", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: true),
                    VisibilidadeKm = table.Column<double>(type: "float", nullable: true),
                    DataHora = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FusoHorario = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrevisaoTempo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrevisaoTempo_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrevisaoTempo_IdUsuario",
                table: "PrevisaoTempo",
                column: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrevisaoTempo");
        }
    }
}
