using EFTute.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFTute.Context
{
   public class SchoolContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-JE21CP1B\SQLEXPRESS;Database=SchoolDBTest;Trusted_Connection=True;");
        }
    }
}
