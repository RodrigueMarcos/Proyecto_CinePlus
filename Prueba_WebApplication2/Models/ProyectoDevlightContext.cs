using Microsoft.EntityFrameworkCore;

namespace Prueba_WebApplication2.Models
{
    public class ProyectoDevlightDB : DbContext
    {
        public ProyectoDevlightDB(DbContextOptions<ProyectoDevlightDB> options) : base(options)
        {

        }
        public DbSet<Person> Person { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-HL6NFTL\SQLEXPRESS;Database=ProyectoIntegrador;Trusted_Connection=True; TrustServerCertificate=True;");
        }

    }
}
