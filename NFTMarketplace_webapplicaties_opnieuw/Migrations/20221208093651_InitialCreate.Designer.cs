﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NFTMarketplace_webapplicaties_opnieuw.Data;

namespace NFTMarketplace_webapplicaties_opnieuw.Migrations
{
    [DbContext(typeof(NFTMarketplaceContext))]
    [Migration("20221208093651_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.Categorie", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Omschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieId");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.Collectie", b =>
                {
                    b.Property<int>("CollectieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AanmaakDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Afbeelding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CreatorFee")
                        .HasColumnType("float");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CollectieId");

                    b.ToTable("Collectie");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.CollectieCategorie", b =>
                {
                    b.Property<int>("CollectieCategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<int>("CollectieId")
                        .HasColumnType("int");

                    b.HasKey("CollectieCategorieId");

                    b.HasIndex("CategorieId");

                    b.HasIndex("CollectieId");

                    b.ToTable("CollectieCategorie");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.CollectieCreator", b =>
                {
                    b.Property<int>("CollectieCreatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CollectieId")
                        .HasColumnType("int");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.HasKey("CollectieCreatorId");

                    b.HasIndex("CollectieId");

                    b.HasIndex("CreatorId");

                    b.ToTable("CollectieCreator");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.Creator", b =>
                {
                    b.Property<int>("CreatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Achternaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Biografie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudoniem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CreatorId");

                    b.ToTable("Creator");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalePrijs")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aantal")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Prijs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducten");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AanmaakDatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("AantalBeschikbaar")
                        .HasColumnType("int");

                    b.Property<string>("Afbeelding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CollectieId")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Prijs")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CollectieId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.ProductProperty", b =>
                {
                    b.Property<int>("ProductPropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("ProductPropertyId");

                    b.HasIndex("ProductId");

                    b.HasIndex("PropertyId");

                    b.ToTable("ProductProperty");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Schaarsheid")
                        .HasColumnType("int");

                    b.HasKey("PropertyId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.CollectieCategorie", b =>
                {
                    b.HasOne("NFTMarketplace_webapplicaties_opnieuw.Models.Categorie", "Categorie")
                        .WithMany("CollectieCategorieën")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NFTMarketplace_webapplicaties_opnieuw.Models.Collectie", "Collectie")
                        .WithMany("CollectieCategorieën")
                        .HasForeignKey("CollectieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.CollectieCreator", b =>
                {
                    b.HasOne("NFTMarketplace_webapplicaties_opnieuw.Models.Collectie", "Collectie")
                        .WithMany("CollectieCreators")
                        .HasForeignKey("CollectieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NFTMarketplace_webapplicaties_opnieuw.Models.Creator", "Creator")
                        .WithMany("CollectieCreators")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.OrderProduct", b =>
                {
                    b.HasOne("NFTMarketplace_webapplicaties_opnieuw.Models.Order", "Order")
                        .WithMany("OrderProducten")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NFTMarketplace_webapplicaties_opnieuw.Models.Product", "Product")
                        .WithMany("OrderProducten")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.Product", b =>
                {
                    b.HasOne("NFTMarketplace_webapplicaties_opnieuw.Models.Collectie", "Collectie")
                        .WithMany("Producten")
                        .HasForeignKey("CollectieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NFTMarketplace_webapplicaties_opnieuw.Models.ProductProperty", b =>
                {
                    b.HasOne("NFTMarketplace_webapplicaties_opnieuw.Models.Product", "Product")
                        .WithMany("ProductProperties")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NFTMarketplace_webapplicaties_opnieuw.Models.Property", "Property")
                        .WithMany("ProductProperties")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
