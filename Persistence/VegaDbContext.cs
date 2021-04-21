using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
        }
        public DbSet<Make> Makes { get; set; }
    }
}