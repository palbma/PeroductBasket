using Microsoft.EntityFrameworkCore;
namespace ASPMVCSHOP.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)"); 
             
        }
        public DbSet<Product> Product { get; set; }      
    }
}
