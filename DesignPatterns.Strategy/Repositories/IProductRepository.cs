using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Strategy.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductAsync(string id);
        Task<List<Product>> GetProductsByUserIdAsync(string userId);
        Task CreateProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(string id);
    }
}
