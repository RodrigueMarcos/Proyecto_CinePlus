using CinePlus_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinePlus_DAL
{
    public class CinePlusDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        public CinePlusDbContext(DbContextOptions<CinePlusDbContext> options) : base(options)
        {

        }

        //Buscar mas información
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seed
           //var questions = new Person();

           //modelBuilder.Entity<Person>().HasData(questions);
        }
    }
}
