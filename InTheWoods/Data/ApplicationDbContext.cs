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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());

            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Comment>();

                modelBuilder.Entity<SubComment>()
                    .HasKey(bc => new { bc.Id, bc.CommentId, bc.UserId, bc.AdminId });
                modelBuilder.Entity<SubComment>()
                    .HasOne(bc => bc.Comment)
                    .WithMany(b => b.SubComments)
                    .HasForeignKey(bc => bc.CommentId);


                modelBuilder.Entity<Event>();


            }
        }
    }
}