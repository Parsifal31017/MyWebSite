﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyWebSite.Models;

namespace MyWebSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyWebSite.Models.Company> Company { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Ads> Ads { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Users> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<AdsAssignment> AdsAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ads>().ToTable("Ads");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Company>().ToTable("Company");
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Users>().ToTable("Instructor");
            modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
            modelBuilder.Entity<AdsAssignment>().ToTable("AdsAssignment");

            modelBuilder.Entity<AdsAssignment>()
                .HasKey(c => new { c.AdsID, c.InstructorID });
        }
    }
}
