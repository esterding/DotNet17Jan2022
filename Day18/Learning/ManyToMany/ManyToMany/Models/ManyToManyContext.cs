using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Models
{
    public class ManyToManyContext: DbContext
    {
        public ManyToManyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<UserInterest> UserInterests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interest>().HasData(
                new Interest() { Id = 1, InterestName = "Swimming" },
                new Interest() { Id = 2, InterestName = "Jogging" },
                new Interest() { Id = 3, InterestName = "Hiking" }
                );

            modelBuilder.Entity<UserInterest>().HasKey(ui => new { ui.UserId, ui.InterestId });
            base.OnModelCreating(modelBuilder);

            

            //modelBuilder.Entity<User>()
            //            .HasMany<Interest>(s => s.Interests)
            //            .WithMany(c => c.Users)
            //            .Map(cs =>
            //            {
            //                cs.MapLeftKey("StudentRefId");
            //                cs.MapRightKey("CourseRefId");
            //                cs.ToTable("StudentCourse");
            //            });

        }

    //    protected override void Seed(ManyToManyContext context)
    //    {
    //        ManyToManyRelationship(context);


    //        context.Entity<Interest>().HasData(
    //            new Interest { InterestName = "Swimming" },
    //            new Interest { InterestName = "Scarface" }
    //        );



    //        context.Entity<Interest>().HasData(
    //            new User
    //            {
    //                Name = "Marlon Brando",
    //                Interests = new List<Interest> { interest1 }
    //            },
    //            new User
    //            {
    //                Name = "Al Pacino",
    //                Interests = new List<Interest> { interest1, interest2 }
    //            });
    //    }
    //}
    }

}
