using System.Text.Json.Serialization;
using GerenciadorDeProjetos.Data;
using GerenciadorDeProjetos.Repositories;
using GerenciadorDeProjetos.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// --- IN�CIO DAS NOVAS LINHAS ---
// AddScoped significa que uma nova inst�ncia dos reposit�rios ser� criada
// para cada requisi��o HTTP, e a mesma inst�ncia ser� usada durante
// todo o ciclo de vida dessa requisi��o.
// **ANTES DE USAR UNIT OF WORK**
//builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
//builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
// --- FIM DAS NOVAS LINHAS ---
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


//builder.Services.AddControllers();
// *** SOLU��O: Adicione esta configura��o ***
builder.Services.AddControllers().AddJsonOptions(options =>
{
    // Ignora os ciclos de refer�ncia em vez de lan�ar uma exce��o.
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
