using ECommerce_Sat.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_Sat.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }


        // Aqui se mapea la identidad para mapear, es decir crear la tabla. 
        public DbSet<Country> Contruies { get; set; } // la tabla se debe llamar en plural 

        // Crear un indice para la tabla countries.
        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
        
        base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); 
        
        } 


    }
}
