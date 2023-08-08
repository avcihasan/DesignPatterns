using DesignPatterns.Decorator.Models;

namespace DesignPatterns.Decorator.Repositories.Decorators
{
    public abstract class BaseProductRepositoryDecorator : IProductRepository
    {
        readonly IProductRepository _repository;

        protected BaseProductRepositoryDecorator(IProductRepository repository)
        {
            _repository = repository;
        }

        public virtual async Task<Product> CreateAsync(Product product)
            =>await _repository.CreateAsync(product);

        public virtual async Task DeleteAsync(int productId)
            => await _repository.DeleteAsync(productId);

        public virtual async Task<List<Product>> GetAllAsync()
            => await _repository.GetAllAsync();

        public virtual async Task<List<Product>> GetAllAsync(string userId)
            => await _repository.GetAllAsync(userId);

        public virtual async Task<Product> GetByIdAsync(int productId)
            => await _repository.GetByIdAsync(productId);

        public virtual async Task UpdateAsync(Product product)
            => await _repository.UpdateAsync(product);
    }
}
