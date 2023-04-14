using CinePlus_DAL.Models;
using Microsoft.EntityFrameworkCore;


namespace CinePlus_DAL;
public class CinePlusDBContext : DbContext
{
    public CinePlusDBContext(DbContextOptions options)
        : base(options)
    {
    }

    public CinePlusDBContext() : base()
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Genere> Generes { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovScreening> MovScreenings { get; set; }
    public DbSet<MovTheater> MovTheaters { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<MovieGenere> MovieGeneres { get; set; }
    public DbSet<MoviePerson> MoviePeople { get; set; }

}
