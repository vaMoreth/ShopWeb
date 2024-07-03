using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Shop.Models;
using Microsoft.AspNetCore.Identity;

namespace Shop.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
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
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2},
                new Category { Id = 3, Name = "History", DisplayOrder = 3}
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Network",
                    StreetAdress = "123 Network st",
                    City = "Network",
                    PostalCode = "01-918",
                    State = "Nt",
                    PhoneNumber = "123123123"
                },
                new Company
                {
                    Id = 2,
                    Name = "Dogjob",
                    StreetAdress = "123 Dogjob st",
                    City = "Dogjob",
                    PostalCode = "01-819",
                    State = "Dj",
                    PhoneNumber = "321321321"
                }, 
                new Company
                {
                    Id = 3,
                    Name = "Cathatch",
                    StreetAdress = "123 Cathatch st",
                    City = "Cathatch",
                    PostalCode = "01-819",
                    State = "Ch",
                    PhoneNumber = "123321123"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Story of Civilization",
                    Author = "William Durant",
                    Description = "\"The Story of Civilization\" by Will Durant is an eleven-volume series that chronicles the history of Western civilization, offering a comprehensive and accessible narrative from ancient times to the early 19th century. Renowned for its engaging prose and thorough research, the series explores the cultural, social, and political developments that have shaped the modern world.",
                    ISBN = "123321123321",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Iliada",
                    Author = "Homer",
                    Description = "\"The Iliad\" by Homer is an ancient Greek epic poem that recounts the significant events of the final weeks of the Trojan War, focusing on the hero Achilles' rage and its devastating consequences. It explores themes of heroism, wrath, and the tragic cost of war.",
                    ISBN = "123321123321",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "The Road To Serfdom",
                    Author = "Friedrich Von Hayek",
                    Description = "\"The Road to Serfdom\" by Friedrich von Hayek argues that central planning and government control of economic decisions inevitably lead to tyranny and the loss of individual freedoms, advocating instead for free-market capitalism as the safeguard of personal liberty.",
                    ISBN = "123321123321",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "American Caesar",
                    Author = "William Manchester",
                    Description = "\"American Caesar\" by William Manchester is a comprehensive biography of General Douglas MacArthur, depicting his complex character and monumental impact on both American and world history, from World War I to the Korean War.",
                    ISBN = "123321123321",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Masters of Doom",
                    Author = "David Kushner",
                    Description = "\"Masters of Doom\" by David Kushner is a gripping chronicle of the rise of id Software, focusing on the dynamic partnership of John Carmack and John Romero, who revolutionized the video game industry with their creation of the iconic game \"Doom.\" The book delves into their pioneering innovations, the culture of the gaming world, and the personal and professional tensions that shaped their journey.",
                    ISBN = "123321123321",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Twelve Against the Gods",
                    Author = "William Bollito",
                    Description = "\"Twelve Against the Gods\" by William Bolitho is a compelling exploration of twelve extraordinary historical figures who defied convention and embraced risk, shaping the world through their audacity and vision. Bolitho's vivid narratives illustrate the timeless human spirit of adventure and ambition.",
                    ISBN = "123321123321",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );
        }                                                                
    }
}
