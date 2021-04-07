using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
namespace CodeExchange.Models
{
  public class CodeExchangeContext : IdentityDbContext<AppUser>
  {
    public virtual DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Forum> Forums { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<AppUserForumPost> AppUserForumPost { get; set; }

    public CodeExchangeContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

            
            builder.Entity<IdentityRole>(entity => { entity.ToTable(name: "Role"); });

            builder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("UserRoles"); });

            builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });

            builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });

            builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });

            builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });
      builder.Entity<Post>()
        .HasData(

          new Post { PostId = 1, Likes = 2, Dislikes = 0, Title= "Python Sucks", Content = "Python dookie", CreationDate = DateTime.Now.AddHours(5), CreatorId = 1, IsVisible = true },
          new Post { PostId = 2, Likes = 100, Dislikes = 0, Title= "Swift Sucks", Content = "Swift dookie", CreationDate = DateTime.Now, CreatorId = 2, IsVisible = true },
          new Post { PostId = 3, Likes = 3, Dislikes = 0, Title= "C# Sucks", Content = "C# dookie", CreationDate = DateTime.Now, CreatorId = 3, IsVisible = true },
          new Post { PostId = 4, Likes = 9, Dislikes = 0, Title= "Java Sucks", Content = "Java dookie", CreationDate = DateTime.Now, CreatorId = 4, IsVisible = true },
          new Post { PostId = 5, Likes = 0, Dislikes = 10, Title= "JavaScript Sucks", Content = "JavaScript dookie", CreationDate = DateTime.Now, CreatorId = 1, IsVisible = true }

      );
    }
  }
}