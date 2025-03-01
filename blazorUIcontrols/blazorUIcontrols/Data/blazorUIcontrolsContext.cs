using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using blazorUIcontrols.Models;

namespace blazorUIcontrols.Data
{
    public class blazorUIcontrolsContext : DbContext
    {
        public blazorUIcontrolsContext (DbContextOptions<blazorUIcontrolsContext> options)
            : base(options)
        {
        }

        public DbSet<blazorUIcontrols.Models.Movie> Movie { get; set; } = default!;
    }
}
