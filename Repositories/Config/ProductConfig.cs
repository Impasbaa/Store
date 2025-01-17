using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/1.jpg", ProductName = "Elechek", Price = 20000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId = 1, ImageUrl = "/images/2.jpg", ProductName = "Kurzhun", Price = 10000, ShowCase = false },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/3.jpg", ProductName = "Chapan", Price = 25000, ShowCase = false },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/4.jpg", ProductName = "Chyptama", Price = 15000, ShowCase = false },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/5.jpg", ProductName = "Beldemchi", Price = 20000, ShowCase = false },
                new Product() { ProductId = 6, CategoryId = 2, ImageUrl = "/images/6.jpg", ProductName = "Takyia", Price = 13000, ShowCase = false },
                new Product() { ProductId = 7, CategoryId = 2, ImageUrl = "/images/7.jpg", ProductName = "Chapan-Kurtka", Price = 23000, ShowCase = false }
            );
        }
    }
}