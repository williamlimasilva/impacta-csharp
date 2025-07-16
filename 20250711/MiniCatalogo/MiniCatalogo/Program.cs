using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MiniCatalogo.Core.Interfaces;
using MiniCatalogo.Infrastructure.Data;
using MiniCatalogo.Infrastructure.Services;

//1. Configuração de WEB API
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseInMemoryDatabase("ProductDB"));




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//2. Configuração de Injeção de Dependência]
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//3. Criação da rota ou Endpoint Monolitico
//* Ferindo o principio SRP (Single Responsibility Principle)
app.MapPost("/products", async (CreateProductRequest request, string name, decimal price, string type) =>
{
    try
    {
        var product = await productService.CreateProductAsync(request.Name, request.Price, request.Type);
        return Results.Created($"/products/{product.Id}", product);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
});

app.MapGet("/products", async (ProductDbContext dbContext) =>
{
    var products = await dbContext.Products.ToListAsync();
    return Results.Ok(products);
});


app.Run();


public record CreateProductRequest(string Name, decimal Price, string Type);

//4. Definições de Entidade e Context
//* Ferindo o DIP (Dependency Inversion Principle) - Alto Acoplamento
//public class Product
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//    public string Type { get; set; }
//}

//public class ProductDbContext : DbContext
//{
//    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
//    public DbSet<Product> Products { get; set; }
//}


