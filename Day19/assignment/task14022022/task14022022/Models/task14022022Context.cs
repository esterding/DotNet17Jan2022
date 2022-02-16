using Microsoft.EntityFrameworkCore;

namespace task14022022.Models
{
    public class task14022022Context : DbContext
    {
        public task14022022Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
          
        //}
    }
}
