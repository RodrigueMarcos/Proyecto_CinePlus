using Microsoft.EntityFrameworkCore;
using CinePlus_BL.Services;
using CinePlus_DAL;
using System.Net;
using CinePlus_BL.Dtos;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                      });
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<CinePlusDBContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("CinePlusDBContext")));

//builder.Services.AddDbContext<CinePlusDBContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("CinePlusDBContext")));

ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

builder.Services.AddScoped<ICinemaService, CinemaService>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IGenereService, GenereService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovScreeningService, MovScreeningService>();
builder.Services.AddScoped<IMovTheaterService, MovTheaterService>();


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

// Create a migration
//dotnet ef migrations add Third_Migration --project CinePlus_DAL --startup-project Cineplus
//Run last migration
//dotnet ef database update --project CinePlus_DAL --startup-project Cineplus