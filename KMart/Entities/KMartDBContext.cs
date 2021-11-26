using Microsoft.EntityFrameworkCore;

namespace KMart.Entities
{
    public class KMartDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-VV884KE\SQLEXPRESS;Initial Catalog=KMartDB;Integrated Security=True");
        }

    }
}
