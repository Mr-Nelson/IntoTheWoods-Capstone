using InTheWoods.Configurations;
using InTheWoods.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace InTheWoods.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        { }

        //public DbSet<Admin> Admins { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<SubComment> SubComments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());

            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Comment>()
                .HasKey(b => new { b.Id });
                modelBuilder.Entity<Comment>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

                modelBuilder.Entity<Event>()
                .HasKey(b => new { b.EventId });
                modelBuilder.Entity<Event>()
                .Property(b => b.EventId)
                .ValueGeneratedOnAdd();

                modelBuilder.Entity<Document>()
                .HasKey(b => new { b.DocumentId });
                modelBuilder.Entity<Document>()
                .Property(b => b.DocumentId)
                .ValueGeneratedOnAdd();

                modelBuilder.Entity<Department>()
                .HasKey(b => new { b.DepartmentId });
                modelBuilder.Entity<Department>()
                .Property(b => b.DepartmentId)
                .ValueGeneratedOnAdd();

                modelBuilder.Entity<SubComment>()
                 .HasKey(b => new { b.Id });
                modelBuilder.Entity<SubComment>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            }
        }
    }
}