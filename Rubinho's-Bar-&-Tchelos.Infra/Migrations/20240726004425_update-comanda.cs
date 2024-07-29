using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rubinho_s_Bar___Tchelos.Infra.Migrations
{
    /// <inheritdoc />
    public partial class updatecomanda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBPedido_TBComanda_Conta_Id",
                table: "TBPedido");

            migrationBuilder.RenameColumn(
                name: "Conta_Id",
                table: "TBPedido",
                newName: "Comanda_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TBPedido_Conta_Id",
                table: "TBPedido",
                newName: "IX_TBPedido_Comanda_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBPedido_TBComanda_Comanda_Id",
                table: "TBPedido",
                column: "Comanda_Id",
                principalTable: "TBComanda",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBPedido_TBComanda_Comanda_Id",
                table: "TBPedido");

            migrationBuilder.RenameColumn(
                name: "Comanda_Id",
                table: "TBPedido",
                newName: "Conta_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TBPedido_Comanda_Id",
                table: "TBPedido",
                newName: "IX_TBPedido_Conta_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBPedido_TBComanda_Conta_Id",
                table: "TBPedido",
                column: "Conta_Id",
                principalTable: "TBComanda",
                principalColumn: "Id");
        }
    }
}
