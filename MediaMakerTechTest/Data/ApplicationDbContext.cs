using MediaMakerTechTest.Models;
using Microsoft.EntityFrameworkCore;

namespace PostmanSandbox.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Request> Requests { get; set; }
    }
}
