using BizLand.Models;
using Microsoft.EntityFrameworkCore;

namespace BizLand.DAL
{
    public class BizLandDbContext:DbContext
    {
        public BizLandDbContext(DbContextOptions<BizLandDbContext> options):base(options)
        {
            
        }
        public DbSet<Features> Features { get; set; }
        public DbSet<Service> Services { get; set; } 
        public DbSet<Testimonials> Testimonials { get; set; }
    }
}
