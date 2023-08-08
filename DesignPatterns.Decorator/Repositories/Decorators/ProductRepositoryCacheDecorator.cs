using DesignPatterns.Decorator.Models;
using Microsoft.Extensions.Caching.Memory;

namespace DesignPatterns.Decorator.Repositories.Decorators
{
    public class ProductRepositoryCacheDecorator : BaseProductRepositoryDecorator
    {
        readonly IMemoryCache _memoryCache;
        const string ProductCacheName = "products";
        public ProductRepositoryCacheDecorator(IProductRepository repository, IMemoryCache memoryCache) : base(repository)
        {
            _memoryCache = memoryCache;
        }

        public override async Task<List<Product>> GetAllAsync()
        {
            if (_memoryCache.TryGetValue(ProductCacheName, out List<Product> products))
                return products;
            await UpdateCache();
            return _memoryCache.Get<List<Product>>(ProductCacheName);
        }
        public override async Task<List<Product>> GetAllAsync(string userId)
        {
            return (await GetAllAsync()).Where(x => x.UserId == userId).ToList();
        }
        public override async Task<Product> CreateAsync(Product product)
        {
            await base.CreateAsync(product);
            await UpdateCache();
            return product;
        }
        public override async Task DeleteAsync(int productId)
        {
            await base.DeleteAsync(productId);
            await UpdateCache();
        }
        public override async Task UpdateAsync(Product product)
        {
            await base.UpdateAsync(product);
            await UpdateCache();
        }
        public override async Task<Product> GetByIdAsync(int productId)
        {
            return (await GetAllAsync()).First(x=>x.Id==productId);
        }
        private async Task UpdateCache()
            => _memoryCache.Set(ProductCacheName, await base.GetAllAsync());

    }
}
