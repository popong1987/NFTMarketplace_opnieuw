using Microsoft.EntityFrameworkCore.Migrations;

namespace NFTMarketplace_webapplicaties_opnieuw.Migrations
{
    public partial class WinkelmandjeBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsWinkelmandje",
                table: "Order",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWinkelmandje",
                table: "Order");
        }
    }
}
