using DesignPatterns.Decorator.Models;

namespace DesignPatterns.Decorator.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int productId);
        Task<List<Product>> GetAllAsync();
        Task<List<Product>> GetAllAsync(string userId);
        Task<Product> CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int productId);
    }
}
