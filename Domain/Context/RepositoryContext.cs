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

        public DbSet<User> Users { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Employee> Emplyee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.Gender)
                .HasConversion(new EnumToStringConverter<Gender>());


            modelBuilder.Entity<User>().HasData(new InitUser().GetInitData());
        }

    }
}
