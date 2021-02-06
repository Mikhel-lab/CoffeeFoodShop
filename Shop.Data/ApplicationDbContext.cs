using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>()
                .HasOne(f => f.Category)
                .WithMany(c => c.Foods)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ShoppingCartItem>()
                .HasOne(sci => sci.Food);

            modelBuilder.Entity<ApplicationUser>()
                .HasIndex(user => user.Email)
                .IsUnique(true);

			string ADMIN_ID = "E8FCF5FF-D401-4B95-8D6A-E77126D6064E";
			string ROLE_ID = "BAB96E35-AD6F-4AAE-B37C-74890B37A93C";

			modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
			{
				Id = ROLE_ID,
				Name = "AdminUser",
				NormalizedName = "AdminUser",
				ConcurrencyStamp = ROLE_ID
			});

			var appUser = new ApplicationUser
			{
				Id = ADMIN_ID,
				Email = "admin@tchibo.com",
				EmailConfirmed = false,
				LockoutEnabled = false,
				FirstName = "Super",
				LastName = "AdminUser",
				UserName = "admin@tchibo.com",
				NormalizedEmail = "admin@tchibo.com",
				NormalizedUserName = "admin@tchibo.com"
			};

			PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
			appUser.PasswordHash = passwordHasher.HashPassword(appUser, "Icui4cu");

			modelBuilder.Entity<ApplicationUser>().HasData(appUser);

			modelBuilder.Entity<IdentityUserRole<string>>()
				.HasData(new IdentityUserRole<string>
				{
					RoleId = ROLE_ID,
					UserId = ADMIN_ID
				});








		}

		public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
       // public DbSet<ImageModel> Images { get; set; }

    }
}
