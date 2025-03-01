using Microsoft.EntityFrameworkCore;

namespace jobZilaRazor.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Jobs> jobs { get; set; }
        public DbSet<Blogs> blogs { get; set; }


    }
}
