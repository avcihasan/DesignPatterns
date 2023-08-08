using DesignPatterns.Decorator.Models;

namespace DesignPatterns.Decorator.Repositories.Decorators
{
    public class ProductRepositoryLoggingDecorator : BaseProductRepositoryDecorator
    {
        readonly ILogger<ProductRepositoryLoggingDecorator> _logger;
        public ProductRepositoryLoggingDecorator(IProductRepository repository, ILogger<ProductRepositoryLoggingDecorator> logger) : base(repository)
        {
            _logger = logger;
        }

        public override Task<Product> CreateAsync(Product product)
        {
            _logger.LogInformation("CreateAsync metodu çalıştı");
            return base.CreateAsync(product);
        }

        public override Task DeleteAsync(int productId)
        {
            _logger.LogInformation("DeleteAsync metodu çalıştı");
            return base.DeleteAsync(productId); 
        }
    
        public override Task<List<Product>> GetAllAsync()
        {
            _logger.LogInformation("GetAllAsync metodu çalıştı");
            return base.GetAllAsync();
        }
        public override Task<List<Product>> GetAllAsync(string userId)
        {
            _logger.LogInformation("GetAllAsync(userId) metodu çalıştı");
            return base.GetAllAsync(userId);
        }

        public override Task<Product> GetByIdAsync(int productId)
        {
            _logger.LogInformation("GetByIdAsync metodu çalıştı");
            return base.GetByIdAsync(productId);
        }
        public override Task UpdateAsync(Product product)
        {
            _logger.LogInformation("UpdateAsync metodu çalıştı");
            return base.UpdateAsync(product);
        }
    }
}
