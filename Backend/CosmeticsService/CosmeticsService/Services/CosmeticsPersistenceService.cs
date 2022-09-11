using CosmeticsService.Context;
using CosmeticsService.Interfaces;
using CosmeticsService.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CosmeticsService.Services
{
    public class CosmeticsPersistenceService : ICosmeticsPersistenceService
    {
        private readonly CosmeticsDbContext _dbContext;

        public CosmeticsPersistenceService(CosmeticsDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void AddProduct(Product product)
        {
            this._dbContext.Products!.Add(product);
            this._dbContext.SaveChanges();
        }

        public void DeleteProduct(string productName)
        {
            Product? product = this.GetProductByName(productName);

            if (product == null)
            {
                throw new KeyNotFoundException($"Could not find {productName} in the database");
            }

            this._dbContext.Products!.Remove(product);
            this._dbContext.SaveChanges();
        }

        public Product? GetProductByName(string productName)
        {
            return this._dbContext.Products!
                .Include(product => product.ProductCategory)
                .Include(product => product.Manufacturer)
                .FirstOrDefault(x => x.Name == productName);
        }

        public Product? GetProductById(int productId)
        {
            return this._dbContext.Products!
                .Include(product => product.ProductCategory)
                .Include(product => product.Manufacturer)
                .FirstOrDefault(x => x.Id == productId);
        }

        public ICollection<Product> GetProducts()
        {
            return this._dbContext.Products!
                .Include(product => product.ProductCategory)
                .Include(product => product.Manufacturer)
                .ToList();
        }

        public void UpdateProduct(Product product)
        {
            this._dbContext.Update(product);
            this._dbContext.SaveChanges();
        }
    }
}
