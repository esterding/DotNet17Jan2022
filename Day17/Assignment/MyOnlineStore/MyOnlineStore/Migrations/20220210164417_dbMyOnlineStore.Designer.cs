// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyOnlineStore.Models;

#nullable disable

namespace MyOnlineStore.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20220210164417_dbMyOnlineStore")]
    partial class dbMyOnlineStore
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyOnlineStore.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<int>("CustomerAge")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 101,
                            CustomerAge = 20,
                            CustomerName = "Wong Boon Chuan",
                            Phone = 98880695
                        },
                        new
                        {
                            CustomerId = 102,
                            CustomerAge = 28,
                            CustomerName = "Abdul Razali",
                            Phone = 97520996
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
