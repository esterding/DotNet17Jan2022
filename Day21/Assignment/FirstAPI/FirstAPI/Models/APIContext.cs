using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Tim", Age = 23 },
                new Customer { Id = 2, Name = "Lim", Age = 33 },
                new Customer { Id = 3, Name = "Jim", Age = 43 }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Ling", Role = "Manager" },
                new Employee { Id = 2, Name = "Lim", Role = "Supervisor" },
                new Employee { Id = 3, Name = "Lok", Role = "Administrator" }
           );
        }
    }
}
