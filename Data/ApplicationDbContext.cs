using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
       
           public DbSet<Category> Categories { get; set; }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId=1, Name="Laptops", DisplayOrder=1},
                 new Category { CategoryId = 2, Name = "Phones", DisplayOrder = 2 },
                  new Category { CategoryId = 3, Name = "Printers", DisplayOrder = 3 }
                );
        }
    }
}

