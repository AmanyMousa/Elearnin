using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Elearnin.Models
{
    public class elearningContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Subscribe> Subscriptions { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=Elearning;Trusted_Connection=True; TrustServerCertificate=True;");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define composite primary key
            modelBuilder.Entity<Subscribe>() .HasKey(s => new { s.UserId, s.CourseId });
            modelBuilder.Entity<Subscribe>().HasOne(s => s.User).WithMany(u => u.corses) .HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Cascade); 
            modelBuilder.Entity<Subscribe>().HasOne(s => s.Course).WithMany(c => c.students).HasForeignKey(s => s.CourseId).OnDelete(DeleteBehavior.Cascade);  
            modelBuilder.Entity<Subscribe>() .HasOne(s => s.User).WithMany(u => u.corses).HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Restrict);
        }


    }
  
}
