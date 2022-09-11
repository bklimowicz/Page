using CosmeticsService.Dto;
using CosmeticsService.Interfaces;
using CosmeticsService.Model;
using Microsoft.EntityFrameworkCore;

namespace CosmeticsService.Context
{
    public class CosmeticsDbContext : DbContext
    {
        public CosmeticsDbContext(DbContextOptions<CosmeticsDbContext> options) : base(options)
        {
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductCategory>? ProductCategories { get; set; }
        public DbSet<Manufacturer>? Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
