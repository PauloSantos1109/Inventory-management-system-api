using InventoryApp.Domain.Entities;

namespace InventoryApp.Domain.Interfaces;

public interface IProductRepository
{
    Task AddAsync(Product product);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(Guid id);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Guid id);
}
