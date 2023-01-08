using MediaMakerTechTest.Models;
using Microsoft.EntityFrameworkCore;

namespace PostmanSandbox.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Addition> Additions { get; set; }
        public DbSet<Subtraction> Subtractions { get; set; }
        public DbSet<Multiplication> Multiplications { get; set; }
        public DbSet<Division> Divisions { get; set; }
    }
}
