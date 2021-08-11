using System.Data.Entity;
using RecapProject1.Entities;

namespace RecapProject1
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
