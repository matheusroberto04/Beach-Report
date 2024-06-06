using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beach_Report.Migrations
{
    /// <inheritdoc />
    public partial class primeira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tabela_Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_De_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CPF = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Telefone = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Senha_Hash = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_De_Reportes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    IdUsuario = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Descricao_Relato = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data_Da_Postagem = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_De_Reportes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabela_De_Reportes_Tabela_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Tabela_Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Descricao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    IdUsuario = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ReportarId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Descricao_Do_Reporte = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data_Do_Reporte = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Descricao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabela_Descricao_Tabela_De_Reportes_ReportarId",
                        column: x => x.ReportarId,
                        principalTable: "Tabela_De_Reportes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabela_Descricao_Tabela_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Tabela_Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_De_Reportes_IdUsuario",
                table: "Tabela_De_Reportes",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Descricao_IdUsuario",
                table: "Tabela_Descricao",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Descricao_ReportarId",
                table: "Tabela_Descricao",
                column: "ReportarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tabela_Descricao");

            migrationBuilder.DropTable(
                name: "Tabela_De_Reportes");

            migrationBuilder.DropTable(
                name: "Tabela_Usuario");
        }
    }
}
