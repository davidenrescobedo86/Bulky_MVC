using BulkyWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories {  get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1},
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company 
                { 
                    Id = 1, 
                    Name = "Tech Solution", 
                    StreetAddress = "12940 NW 9th Lane", 
                    City = "Miami", State = "Fl", 
                    PostalCode = "33182",
                    PhoneNumber = "5099868831"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "13000 SW 85th St",
                    City = "Miami",
                    State = "Fl",
                    PostalCode = "33183",
                    PhoneNumber = "5094407609"
                },
                new Company
                {
                    Id = 3,
                    Name = "Arcade",
                    StreetAddress = "13540 SW 88th St",
                    City = "Miami",
                    State = "Fl",
                    PostalCode = "33188",
                    PhoneNumber = "5094404110"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae sodales libero",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId  = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Test",
                    Author = "Dee F",
                    Description = "Praesent vitae sodales libero",
                    ISBN = "SWD9999002",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "ARcade",
                    Author = "JF T",
                    Description = "Praesent vitae sodales libero",
                    ISBN = "SWD9999003",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
