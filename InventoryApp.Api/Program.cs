using InventoryApp.Application.Services;
using InventoryApp.Domain.Interfaces;
using InventoryApp.Infrastructure.Data;
using InventoryApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContext SQLite
builder.Services.AddDbContext<InventoryDbContext>(options =>
    options.UseSqlite("Data Source=inventory.db"));

// Services e Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<InventoryService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
