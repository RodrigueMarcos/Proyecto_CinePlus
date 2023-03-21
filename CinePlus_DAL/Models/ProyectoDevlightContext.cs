using Microsoft.EntityFrameworkCore;

namespace CinePlus_DAL.Models
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
