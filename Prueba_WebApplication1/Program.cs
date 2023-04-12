using Microsoft.EntityFrameworkCore;
using CinePlus_DAL.Models;
using CinePlus_BL.Services;
using CinePlus_DAL;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://example.com").AllowAnyHeader()
                                                  .AllowAnyMethod(); ;
                      });
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<CinePlusContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProyectoIntegrador")));

builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IBookService, BookService>();



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
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();
