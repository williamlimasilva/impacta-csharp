using System.Text.Json.Serialization;
using GerenciadorDeProjetos.Data;
using GerenciadorDeProjetos.Repositories;
using GerenciadorDeProjetos.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// --- INÍCIO DAS NOVAS LINHAS ---
// AddScoped significa que uma nova instância dos repositórios será criada
// para cada requisição HTTP, e a mesma instância será usada durante
// todo o ciclo de vida dessa requisição.
// **ANTES DE USAR UNIT OF WORK**
//builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
//builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
// --- FIM DAS NOVAS LINHAS ---
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


//builder.Services.AddControllers();
// *** SOLUÇÃO: Adicione esta configuração ***
builder.Services.AddControllers().AddJsonOptions(options =>
{
    // Ignora os ciclos de referência em vez de lançar uma exceção.
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
