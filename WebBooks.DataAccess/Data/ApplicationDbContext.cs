using Microsoft.EntityFrameworkCore;
using WebBooks.Models;

namespace WebBooks.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );

            modelbuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 7, Title = "Mistborn", ISBN = "A-0010-Z", Author = "Brandon Sanderson",
                    Description =
                        "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 100, Price = 15, Price50 = 200, Price100 = 300, CategoryId = 2, ImageUrl = ""
                },
                new Product
                {
                    Id = 8, Title = "The Brothers Karamazov", ISBN = "B-0020-Z", Author = "Fyodor Dostoevsky",
                    Description =
                        "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 80, Price = 20, Price50 = 150, Price100 = 350, CategoryId = 2, ImageUrl = ""
                },
                new Product
                {
                    Id = 9, Title = "The Lord of the Rings", ISBN = "C-0020-Z", Author = "J.R.R. Tolkien",
                    Description =
                        "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 90, Price = 17, Price50 = 130, Price100 = 400, CategoryId = 3, ImageUrl = ""
                }
            );
        }
    }
}