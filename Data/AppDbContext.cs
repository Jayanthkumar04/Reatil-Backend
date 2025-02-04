using Microsoft.EntityFrameworkCore;
using Reatil_Backend.Model;

namespace Reatil_Backend.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }


        public DbSet<Product> Products { get; set; }

        public DbSet<Colour> Colours { get; set; }
        public DbSet<Power> Powers{ get; set; }


    }
}
