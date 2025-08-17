namespace InventoryApp.Domain.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal CostPrice { get; private set; }
    public decimal ProfitMargin { get; private set; }

    public decimal SalePrice => CostPrice + (CostPrice * ProfitMargin / 100);

    public Product(string name, string brand, int quantity, decimal costPrice, decimal profitMargin)
    {
        Id = Guid.NewGuid();
        Name = name;
        Brand = brand;
        Quantity = quantity;
        CostPrice = costPrice;
        ProfitMargin = profitMargin;
    }

    public void AddStock(int amount) => Quantity += amount;
    public void RemoveStock(int amount)
    {
        if (Quantity < amount) throw new InvalidOperationException("Estoque insuficiente.");
        Quantity -= amount;
    }
}
