using Microsoft.EntityFrameworkCore;

namespace MyOnlineStore.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer()
                { 
                    CustomerId = 101,
                    CustomerAge = 20,
                    CustomerName = "Wong Boon Chuan",
                    Phone = 98880695
                },
                new Customer()
                {
                    CustomerId = 102,
                    CustomerAge = 28,
                    CustomerName = "Abdul Razali",
                    Phone = 97520996
                }
            );
        }
    }
}
