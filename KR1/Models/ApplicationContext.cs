using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace KR1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}