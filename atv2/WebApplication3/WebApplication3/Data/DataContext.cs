using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> option) : base(option) { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().Property(c => c.ID).HasColumnName("ContactId");
            modelBuilder.Entity<Contact>().HasKey(c => c.ID);
            modelBuilder.Entity<Contact>().Property(c => c.Name).HasMaxLength(30);
            modelBuilder.Entity<Contact>().Property(c => c.Phone).HasMaxLength(14);

            base.OnModelCreating(modelBuilder);
        }

    }
}
