using Microsoft.EntityFrameworkCore;
using WebApplication31.Data;
using WebApplication31.Interfaces;
using WebApplication31.Interfaces.Services;
using WebApplication31.Models;
using WebApplication31.Repositories;
using WebApplication31.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository<User>, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRepositoryWorker, RepositoryWorker>();

builder.Services.AddDbContext<ApiDbContext>(o => o.UseSqlServer(builder.Configuration["ConnectionString"]));


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
