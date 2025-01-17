using EmployeeApi.Data;
using Microsoft.EntityFrameworkCore;
using EmployeeApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure the connection string to the local SQL Server
string connectionString = "Server=MEHEDI;Database=EmployeeDb;User Id=sa;Password=sa@123456;TrustServerCertificate=True;";

// Add DBContext to the container
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add Swagger
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

app.MapControllers();

app.Run();
