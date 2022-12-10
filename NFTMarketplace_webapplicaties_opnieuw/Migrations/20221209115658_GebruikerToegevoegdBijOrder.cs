using Microsoft.EntityFrameworkCore.Migrations;

namespace NFTMarketplace_webapplicaties_opnieuw.Migrations
{
    public partial class GebruikerToegevoegdBijOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GebruikerId",
                table: "Order",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Order_GebruikerId",
                table: "Order",
                column: "GebruikerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Gebruiker_GebruikerId",
                table: "Order",
                column: "GebruikerId",
                principalTable: "Gebruiker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Gebruiker_GebruikerId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_GebruikerId",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "GebruikerId",
                table: "Order",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
