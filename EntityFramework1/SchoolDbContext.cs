using System;
using System.Collections.Generic;
using System.Text;
using EntityFramework1.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework1
{
    public class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=SchoolDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Studnr = 1001, Birthdate = new DateTime(2000, 5, 18), Name = "Bart" },
                new Student { Id = 2, Studnr = 1002, Birthdate = new DateTime(1997, 2, 14), Name = "Suzanne" },
                new Student { Id = 3, Studnr = 1003, Birthdate = new DateTime(1999, 8, 26), Name = "Sam" },
                new Student { Id = 4, Studnr = 1004, Birthdate = new DateTime(2001, 12, 3), Name = "Inge" });
        }

        public DbSet<Student> Students { get; set; }
    }
}
