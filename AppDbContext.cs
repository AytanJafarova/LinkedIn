using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Connections> Connections { get; set; }
        public DbSet<Educations> Educations { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Certifications> Certifications { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Reactions> Reactions { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<UserGroups> UserGroups { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Experiences> Experiences { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                    .HasOne(user => user.Accounts)
                    .WithOne(account => account.Users)
                    .HasForeignKey<Accounts>(account => account.user_id);

            modelBuilder.Entity<Users>()
                .HasMany(user => user.Connections)
                .WithOne(connection => connection.Users)
                .HasForeignKey(connection => connection.user_id);

            modelBuilder.Entity<Users>()
                .HasMany(user => user.Educations)
                .WithOne(education => education.Users)
                .HasForeignKey(education => education.user_id);

            modelBuilder.Entity<Users>()
                .HasMany(user => user.Experiences)
                .WithOne(experience => experience.Users)
                .HasForeignKey(experience => experience.user_id);

            modelBuilder.Entity<Users>()
                .HasMany(user => user.Skills)
                .WithOne(skill => skill.Users)
                .HasForeignKey(skill => skill.user_id);

            modelBuilder.Entity<Users>()
                .HasMany(user => user.Certifications)
                .WithOne(certification => certification.Users)
                .HasForeignKey(certification => certification.user_id);

            modelBuilder.Entity<Users>()
                .HasMany(user => user.Posts)
                .WithOne(post => post.Users)
                .HasForeignKey(post => post.user_id);

            modelBuilder.Entity<Users>()
                .HasMany(user => user.Reactions)
                .WithOne(reaction => reaction.Users)
                .HasForeignKey(reaction => reaction.user_id);

            modelBuilder.Entity<Users>()
                .HasMany(user => user.Comments)
                .WithOne(comment => comment.Users)
                .HasForeignKey(comment => comment.user_id);

            modelBuilder.Entity<Users>()
                .HasMany(user => user.UserGroups)
                .WithOne(group => group.Users)
                .HasForeignKey(group => group.user_id);

            modelBuilder.Entity<Certifications>()
                .HasMany(certificate => certificate.Skills)
                .WithOne(skill => skill.Certifications)
                .HasForeignKey(skill => skill.certification_id);

            modelBuilder.Entity<Posts>()
                .HasMany(post => post.Reactions)
                .WithOne(reaction => reaction.Posts)
                .HasForeignKey(reaction => reaction.post_id);

            modelBuilder.Entity<Posts>()
                .HasMany(post => post.Comments)
                .WithOne(comment => comment.Posts)
                .HasForeignKey(comment => comment.post_id);

            modelBuilder.Entity<Groups>()
                .HasMany(group => group.UserGroups)
                .WithOne(usergroup => usergroup.Groups)
                .HasForeignKey(usergroup => usergroup.group_id);
        }

        }
}
