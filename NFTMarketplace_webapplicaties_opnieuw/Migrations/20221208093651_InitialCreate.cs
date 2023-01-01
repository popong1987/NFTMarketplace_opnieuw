using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NFTMarketplace_webapplicaties_opnieuw.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategorieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Omschrijving = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategorieId);
                });

            migrationBuilder.CreateTable(
                name: "Collectie",
                columns: table => new
                {
                    CollectieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    AanmaakDatum = table.Column<DateTime>(nullable: false),
                    CreatorFee = table.Column<double>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: false),
                    Afbeelding = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectie", x => x.CollectieId);
                });

            migrationBuilder.CreateTable(
                name: "Creator",
                columns: table => new
                {
                    CreatorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(nullable: false),
                    Achternaam = table.Column<string>(nullable: false),
                    Pseudoniem = table.Column<string>(nullable: true),
                    Biografie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creator", x => x.CreatorId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalePrijs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GebruikerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Schaarsheid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyId);
                });

            migrationBuilder.CreateTable(
                name: "CollectieCategorie",
                columns: table => new
                {
                    CollectieCategorieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectieId = table.Column<int>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectieCategorie", x => x.CollectieCategorieId);
                    table.ForeignKey(
                        name: "FK_CollectieCategorie_Categorie_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categorie",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectieCategorie_Collectie_CollectieId",
                        column: x => x.CollectieId,
                        principalTable: "Collectie",
                        principalColumn: "CollectieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Prijs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Afbeelding = table.Column<string>(nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    AanmaakDatum = table.Column<DateTime>(nullable: false),
                    AantalBeschikbaar = table.Column<int>(nullable: false),
                    CollectieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Collectie_CollectieId",
                        column: x => x.CollectieId,
                        principalTable: "Collectie",
                        principalColumn: "CollectieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollectieCreator",
                columns: table => new
                {
                    CollectieCreatorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorId = table.Column<int>(nullable: false),
                    CollectieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectieCreator", x => x.CollectieCreatorId);
                    table.ForeignKey(
                        name: "FK_CollectieCreator_Collectie_CollectieId",
                        column: x => x.CollectieId,
                        principalTable: "Collectie",
                        principalColumn: "CollectieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectieCreator_Creator_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creator",
                        principalColumn: "CreatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducten",
                columns: table => new
                {
                    OrderProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aantal = table.Column<int>(nullable: false),
                    Prijs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducten", x => x.OrderProductId);
                    table.ForeignKey(
                        name: "FK_OrderProducten_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducten_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProperty",
                columns: table => new
                {
                    ProductPropertyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProperty", x => x.ProductPropertyId);
                    table.ForeignKey(
                        name: "FK_ProductProperty_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProperty_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollectieCategorie_CategorieId",
                table: "CollectieCategorie",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectieCategorie_CollectieId",
                table: "CollectieCategorie",
                column: "CollectieId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectieCreator_CollectieId",
                table: "CollectieCreator",
                column: "CollectieId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectieCreator_CreatorId",
                table: "CollectieCreator",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducten_OrderId",
                table: "OrderProducten",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducten_ProductId",
                table: "OrderProducten",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CollectieId",
                table: "Product",
                column: "CollectieId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperty_ProductId",
                table: "ProductProperty",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperty_PropertyId",
                table: "ProductProperty",
                column: "PropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectieCategorie");

            migrationBuilder.DropTable(
                name: "CollectieCreator");

            migrationBuilder.DropTable(
                name: "OrderProducten");

            migrationBuilder.DropTable(
                name: "ProductProperty");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Creator");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Collectie");
        }
    }
}
