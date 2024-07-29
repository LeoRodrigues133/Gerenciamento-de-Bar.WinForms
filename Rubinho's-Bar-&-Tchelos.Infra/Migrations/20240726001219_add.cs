using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rubinho_s_Bar___Tchelos.Infra.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBComanda_TBMesa",
                table: "TBComanda");

            migrationBuilder.AlterColumn<int>(
                name: "Comanda_Id",
                table: "TBComanda",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TBComanda_TBMesa",
                table: "TBComanda",
                column: "Mesa_Id",
                principalTable: "TBMesa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBComanda_TBMesa",
                table: "TBComanda");

            migrationBuilder.AlterColumn<int>(
                name: "Comanda_Id",
                table: "TBComanda",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBComanda_TBMesa",
                table: "TBComanda",
                column: "Mesa_Id",
                principalTable: "TBMesa",
                principalColumn: "Id");
        }
    }
}
