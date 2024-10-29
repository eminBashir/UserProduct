using Matrix1141EF.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Matrix1141EF.Data
{
    public class AppDbContext : IdentityDbContext<User,Role,int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

      
       
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserProduct>()
                .HasKey(p => new {p.UserId, p.ProductId});
            base.OnModelCreating(builder);
        }

       
    }
    
}
