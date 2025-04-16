using api_test.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<mydbcontext>(a => a.UseSqlServer("Server=DESKTOP-KHBGNKV\\MSSQLSERVER01; Database=apitest ;trusted_connection=true; TrustServerCertificate=true;"));
builder.Services.AddCors(builder => builder.AddPolicy("AllowAll", a => 
a.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

//abdullah //
var app = builder.Build();

//for swagger//

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
