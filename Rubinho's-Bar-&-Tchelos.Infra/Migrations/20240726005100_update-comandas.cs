using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rubinho_s_Bar___Tchelos.Infra.Migrations
{
    /// <inheritdoc />
    public partial class updatecomandas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBPedido_TBComanda_Comanda_Id",
                table: "TBPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_TBPedido_TBComanda_Comanda_Id",
                table: "TBPedido",
                column: "Comanda_Id",
                principalTable: "TBComanda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBPedido_TBComanda_Comanda_Id",
                table: "TBPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_TBPedido_TBComanda_Comanda_Id",
                table: "TBPedido",
                column: "Comanda_Id",
                principalTable: "TBComanda",
                principalColumn: "Id");
        }
    }
}
