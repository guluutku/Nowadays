using Microsoft.EntityFrameworkCore;

namespace Nowadays.Models
{
    public class NowadaysContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:nowadaysConnection"]);
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}