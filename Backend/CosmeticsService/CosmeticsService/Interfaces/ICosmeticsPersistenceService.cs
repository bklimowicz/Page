using CosmeticsService.Model;

namespace CosmeticsService.Interfaces
{
    public interface ICosmeticsPersistenceService
    {
        ICollection<Product> GetProducts();
        Product? GetProductByName(string productName);
        void AddProduct(Product product);
        void DeleteProduct(string productName);
        void UpdateProduct(Product product);
    }
}