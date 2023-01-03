using Labb2_LINQ.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ
{
    public class SchoolContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }

        public DbSet<Course> Courses { get; set; }


        public DbSet<Student> Students { get; set; }


        public DbSet<Teacher> Teachers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=SchoolDb;Trusted_Connection=True;");
        }

        //Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId = 1, TeacherName = "Reidar Nilsson" },
                new Teacher { TeacherId = 2, TeacherName = "Tobias Landen" },
                new Teacher { TeacherId = 3, TeacherName = "Anas Alhussain" }
                );
            modelBuilder.Entity<Course>().HasData(
                new { CourseId = 1, CourseName = "ReactJs", TeacherId = 2 },
                new { CourseId = 2, CourseName = "Agile", TeacherId = 3 },
                new { CourseId = 3, CourseName = "JavaScript", TeacherId = 1 }
                );
            modelBuilder.Entity<Student>().HasData(
                new { StudentId = 1, StudentName = "John Johns", ClassId = 3, CourseId  = 1},
                new { StudentId = 2, StudentName = "Peter Pan", ClassId = 2, CourseId = 2 },
                new { StudentId = 3, StudentName = "Paul Simms", ClassId = 2, CourseId = 3 },
                new { StudentId = 4, StudentName = "Tina Turner", ClassId = 1, CourseId = 2 }
                );
            modelBuilder.Entity<Class>().HasData(
                new { ClassId = 1, ClassName = "Net21" },
                new { ClassId = 2, ClassName = "Java21" },
                new { ClassId = 3, ClassName = "NE23" },
                new { ClassId = 4, ClassName = "NE22" }

                );

      
        }
    }
}
