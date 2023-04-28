using EntityFrameworkTrial.Configurations;
using EntityFrameworkTrial.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTrial
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EntityTrial;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new EmployeeEntityTypeConfiguration().Configure(modelBuilder.Entity<Employee>());
            new RoleEntityTypeConfiguration().Configure(modelBuilder.Entity<Role>());
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
