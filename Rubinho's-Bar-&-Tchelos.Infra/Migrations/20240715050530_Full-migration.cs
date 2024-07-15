using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rubinho_s_Bar___Tchelos.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Fullmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBGarçom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "varchar(50)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cargo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBGarçom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBMesa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDaMesa = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBMesa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Valor = table.Column<string>(type: "varchar(30)", nullable: false),
                    CategoriaProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBProduto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBComanda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Mesa_Id = table.Column<int>(type: "int", nullable: false),
                    Garcom_Id = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DataConclusao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBComanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBComanda_TBGarcom",
                        column: x => x.Garcom_Id,
                        principalTable: "TBGarçom",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TBComanda_TBMesa",
                        column: x => x.Mesa_Id,
                        principalTable: "TBMesa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Produto_Id = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Conta_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBComanda_Conta_Id",
                        column: x => x.Conta_Id,
                        principalTable: "TBComanda",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TBPedido_TBProduto",
                        column: x => x.Produto_Id,
                        principalTable: "TBProduto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBComanda_Garcom_Id",
                table: "TBComanda",
                column: "Garcom_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TBComanda_Mesa_Id",
                table: "TBComanda",
                column: "Mesa_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_Conta_Id",
                table: "TBPedido",
                column: "Conta_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_Produto_Id",
                table: "TBPedido",
                column: "Produto_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBPedido");

            migrationBuilder.DropTable(
                name: "TBComanda");

            migrationBuilder.DropTable(
                name: "TBProduto");

            migrationBuilder.DropTable(
                name: "TBGarçom");

            migrationBuilder.DropTable(
                name: "TBMesa");
        }
    }
}
