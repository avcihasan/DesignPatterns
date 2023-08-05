using DesignPatterns.Strategy.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Strategy.Repositories
{
    public class ProductRepositorySqlServer:IProductRepository
    {
        readonly AppDbContext _appDbContext;

        public ProductRepositorySqlServer(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CreateProductAsync(Product product)
        {
            product.Id = Guid.NewGuid().ToString();
            await _appDbContext.Prodcuts.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(string id)
        {
            _appDbContext.Prodcuts.Remove(await GetProductAsync(id));
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<Product> GetProductAsync(string id)
            =>await _appDbContext.Prodcuts.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<List<Product>> GetProductsByUserIdAsync(string userId)
            => await _appDbContext.Prodcuts.Where(x => x.UserId == userId).ToListAsync();

        public async Task UpdateProductAsync(Product product)
        {
            _appDbContext.Update(product);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
