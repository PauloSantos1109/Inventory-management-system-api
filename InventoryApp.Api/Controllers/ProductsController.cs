using InventoryApp.Application.Services;
using InventoryApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly InventoryService _service;
    public ProductsController(InventoryService service)
    {
        _service = service;
    }


    //Requisição GET do projeto
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _service.GetProducts();
        return Ok(products);
    }

    [HttpGet("total-value")]
    public async Task<IActionResult> TotalValue()
    {
        var total = await _service.GetTotalStockValue();
        return Ok(total);
    }

    [HttpGet("expected-profit")]
    public async Task<IActionResult> ExpectedProfit()

    {
        var profit = await _service.GetExpectedProfit();
        return Ok(profit);
    }




    //Requisição POST do projeto
    [HttpPost]
    public async Task<IActionResult> Add(Product product)
    {
        await _service.AddProduct(product);
        return Ok("Produto adicionado!");
    }
}
