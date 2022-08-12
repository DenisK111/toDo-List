using Architecture.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;

namespace Architecture
{
    public class ListContext : DbContext
    {
        public ListContext()
        {

        }

        public ListContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<todoTask> Tasks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddUserSecrets("269b996e-321b-42ba-801b-8e89074a45d5")
            .Build();

                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }
    }
}