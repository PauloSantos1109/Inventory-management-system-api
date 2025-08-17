using InventoryApp.Domain.Entities;
using InventoryApp.Domain.Interfaces;

namespace InventoryApp.Application.Services;

public class InventoryService
{
    private readonly IProductRepository _repository;

    public InventoryService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task AddProduct(Product product) => await _repository.AddAsync(product);

    public async Task<IEnumerable<Product>> GetProducts() => await _repository.GetAllAsync();

    public async Task<decimal> GetTotalStockValue()
    {
        var products = await _repository.GetAllAsync();
        return products.Sum(p => p.CostPrice * p.Quantity);
    }

    public async Task<decimal> GetExpectedProfit()
    {
        var products = await _repository.GetAllAsync();
        return products.Sum(p => (p.SalePrice - p.CostPrice) * p.Quantity);
    }
}
