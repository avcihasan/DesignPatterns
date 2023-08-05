using DesignPatterns.Strategy.Models;
using MongoDB.Driver;

namespace DesignPatterns.Strategy.Repositories
{
    public class ProductRepositoryMongoDb : IProductRepository
    {
        readonly IMongoCollection<Product> _products;
        public ProductRepositoryMongoDb(IConfiguration configuration)
        {
            var connectionStrings = configuration.GetConnectionString("MongoDb");

            var client = new MongoClient(connectionStrings);
            var database = client.GetDatabase("ProductDb");
            _products = database.GetCollection<Product>("Products");
        }


        public async Task CreateProductAsync(Product product)
        {
           await _products.InsertOneAsync(product);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _products.DeleteOneAsync(x => x.Id == id);
        }

        public async Task<Product> GetProductAsync(string id)
            => await _products.FindSync(x => x.Id == id).FirstOrDefaultAsync();

        public async Task<List<Product>> GetProductsByUserIdAsync(string userId)
            => await _products.FindSync(x => x.UserId == userId).ToListAsync();

        public async Task UpdateProductAsync(Product product)
        {
            await _products.ReplaceOneAsync<Product>(x=>x.Id==product.Id, product);
        }
    }
}
