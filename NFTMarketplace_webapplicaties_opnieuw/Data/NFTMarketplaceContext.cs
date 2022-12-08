using Microsoft.EntityFrameworkCore;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace NFTMarketplace_webapplicaties_opnieuw.Data
{
    public class NFTMarketplaceContext: DbContext
    {
        public NFTMarketplaceContext(DbContextOptions<NFTMarketplaceContext> options) : base(options) 
        {
        }

        public DbSet<CollectieCategorie> CollectiesCategorieën { get; set; }
        public DbSet<Categorie> Categorieën { get; set; }
        public DbSet<Collectie> Collecties { get; set; }


        public DbSet<CollectieCreator> CollectiesCreators { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducten { get; set; }
        public DbSet<Product> Producten { get; set; }
        public DbSet<ProductProperty> productProperties { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<CollectieCategorie>().ToTable("CollectieCategorie");
            modelBuilder.Entity<Categorie>().ToTable("Categorie");
            modelBuilder.Entity<Collectie>().ToTable("Collectie");
            modelBuilder.Entity<CollectieCreator>().ToTable("CollectieCreator");
            modelBuilder.Entity<Creator>().ToTable("Creator");
            modelBuilder.Entity<Order>().ToTable("Order").Property(p => p.TotalePrijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<OrderProduct>().ToTable("OrderProducten").Property(p => p.Prijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().ToTable("Product").Property(p => p.Prijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<ProductProperty>().ToTable("ProductProperty");
            modelBuilder.Entity<Property>().ToTable("Property");
            /*modelBuilder.Entity<Gebruiker>().ToTable("Gebruiker");*/

            modelBuilder.Entity<CollectieCategorie>()
                .HasOne(p => p.Collectie)
                .WithMany(x => x.CollectieCategorieën)
                .HasForeignKey(p => p.CollectieId)
                .IsRequired();

            modelBuilder.Entity<CollectieCategorie>()
                .HasOne(p => p.Categorie)
                .WithMany(x => x.CollectieCategorieën)
                .HasForeignKey(p => p.CategorieId)
                .IsRequired();

            modelBuilder.Entity<CollectieCreator>()
                .HasOne(p => p.Collectie)
                .WithMany(x => x.CollectieCreators)
                .HasForeignKey(p => p.CollectieId)
                .IsRequired();

            modelBuilder.Entity<CollectieCreator>()
                .HasOne(p => p.Creator)
                .WithMany(x => x.CollectieCreators)
                .HasForeignKey(p => p.CreatorId)
                .IsRequired();

            modelBuilder.Entity<OrderProduct>()
                .HasOne(p => p.Order)
                .WithMany(x => x.OrderProducten)
                .HasForeignKey(p => p.OrderId)
                .IsRequired();

            modelBuilder.Entity<OrderProduct>()
                .HasOne(p => p.Product)
                .WithMany(x => x.OrderProducten)
                .HasForeignKey(p => p.ProductId)
                .IsRequired();

            modelBuilder.Entity<ProductProperty>()
                .HasOne(p => p.Product)
                .WithMany(x => x.ProductProperties)
                .HasForeignKey(p => p.ProductId)
                .IsRequired();

            modelBuilder.Entity<ProductProperty>()
                .HasOne(p => p.Property)
                .WithMany(x => x.ProductProperties)
                .HasForeignKey(p => p.PropertyId)
                .IsRequired();


        }
    }
}
