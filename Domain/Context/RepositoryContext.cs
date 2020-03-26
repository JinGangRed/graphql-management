using Domain.Models;
using Domain.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.Gender)
                .HasConversion(new EnumToStringConverter<Gender>());
            modelBuilder.Entity<Company>().OwnsOne(p => p.Address);
            modelBuilder.Entity<CompanyDepartment>()
                .HasKey(c => new { c.DepartmentId, c.CompanyId });

            modelBuilder.Entity<User>().HasData(new InitUser().GetInitData());
            modelBuilder.Entity<Company>().HasData(new InitCompany().GetInitData());
            modelBuilder.Entity<Department>().HasData(new InitDepartment().GetInitData());
        }

    }
}
