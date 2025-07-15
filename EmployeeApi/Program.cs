using EmployeeApi.Data;
using Microsoft.EntityFrameworkCore;
using EmployeeApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure the connection string to the local SQL Server
string connectionString = "Server=db.opuserp.com;Initial Catalog=EmployeeDb;Encrypt=False;User ID=sa;Password=**OpUs246##;Pooling=true;Max Pool Size=32700";

// Add DBContext to the container
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));



 

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
