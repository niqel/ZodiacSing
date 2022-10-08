using ZodiacSign.Domain.IRepositories.IRepositoriesBase;
using ZodiacSign.Domain.IRepositories;
using ZodiacSign.Persistence.Repositories.RepositoriesBase;
using ZodiacSign.Persistence;
using Microsoft.EntityFrameworkCore;
using ZodiacSign.Persistence.Configurations.DbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ZodiacSignDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ZodiacSignConnection")));

builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddTransient<IUnityOfWork, UnityOfWork>();

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
