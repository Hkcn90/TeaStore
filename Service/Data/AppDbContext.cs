using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Service.Entities;

namespace Service.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int,
        IdentityUserClaim<int>, AppUserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductInventory> ProductInventory { get; set; }
        public DbSet<ProductPhotos> ProductPhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
               .HasMany(ur => ur.UserRoles)
               .WithOne(u => u.User)
               .HasForeignKey(ur => ur.UserId)
               .IsRequired();

            builder.Entity<AppRole>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();
        }
        }
}
