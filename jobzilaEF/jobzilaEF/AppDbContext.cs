using jobzilaEF.Models;
using Microsoft.EntityFrameworkCore;


namespace jobzilaEF
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=sadeed\\SQLEXPRESS;Database=testProducts;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }


        // DbSets for your entities
        public DbSet<Product> Products { get; set; }
        
    }


   
}
