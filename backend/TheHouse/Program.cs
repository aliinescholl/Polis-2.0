using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Profiles.MetaProfile;
using Model.Repositories.Interfaces;
using Model.Repositories.MetaRepository;
using Model.Services.Interfaces;
using Model.Services.MetaService;

var builder = WebApplication.CreateBuilder(args);

// Configurar a conexão com o banco de dados PostgreSQL

builder.Services.AddControllers();
builder.Services.AddDbContext<PolisContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Registro de Repositorys
builder.Services.AddTransient<IAutorRepository, AutorRepository>();

// Registro de Services
builder.Services.AddScoped<IMetaService, AutorService>();
// Registro de Mappers
builder.Services.AddAutoMapper(typeof(AutorProfile).Assembly);

builder.Services.AddCors();

var app = builder.Build();


// Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseCors();

app.Run();