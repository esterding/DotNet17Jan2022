using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03FebModelsLibrary;

namespace Task03FebDALEFLibrary
{
    class TaskContext : DbContext
    {
        public TaskContext() : base("conn")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasRequired<Department>(b => b.Department)
                .WithMany(a => a.Employees)
                .HasForeignKey<int>(b => b.Department_Id);

        }
    }
    
}
