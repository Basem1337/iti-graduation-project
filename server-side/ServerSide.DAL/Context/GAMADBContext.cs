using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerSide.DAL.Models;

namespace ServerSide.DAL.Context
{
    public class GAMADBContext: IdentityDbContext<User,IdentityRole<Guid>, Guid>
    {

        public GAMADBContext(DbContextOptions<GAMADBContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cart>().HasKey(c => new { c.UserId, c.ProductId });
            modelBuilder.Entity<Library>().HasKey(l => new { l.UserId, l.ProductId });
            modelBuilder.Entity<Wishlist>().HasKey(w => new { w.UserId, w.ProductId });


            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany(u => u.CartItems)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Library>()
                .HasOne(l => l.User)
                .WithMany(u => u.UserLibrary)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Library>()
                .HasOne(l => l.Product)
                .WithMany(p => p.UserLibrary)
                .HasForeignKey(l => l.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.User)
                .WithMany(u => u.UserWishlist)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.Product)
                .WithMany(p => p.UserWishlist)
                .HasForeignKey(w => w.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            var (products, categories,photos) = ProductSeeder.SeedData();

            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Product>().HasData(products);    
            modelBuilder.Entity<Photo>().HasData(photos);

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }

    }
}
