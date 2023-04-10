using CinePlus_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinePlus_DAL;
public class CinePlusContext : DbContext
{
    public CinePlusContext(DbContextOptions<CinePlusContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Genere> Generes { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovScreening> MovScreenings { get; set; }
    public DbSet<MovTheater> MovTheaters { get; set; }
    public DbSet<Person> People{ get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var server = "localhost";  // Docker container is running on the same machine
        var port = "1433";  // Port number for SQL Server on Docker container
        var username = "sa";  // Default SQL Server username on Docker container
        var password = "DevLightsDBCinePLus@1405";  // SQL Server password on Docker container DevLightsDB
        var database = "ProyectoIntegrador";

        // Connection string to connect to SQL Server on Docker container
        optionsBuilder.UseSqlServer($"Server={server},{port};User Id={username};Password={password};");
    }

}

