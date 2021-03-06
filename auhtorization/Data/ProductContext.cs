using auhtorization.Models;
using Microsoft.EntityFrameworkCore;

namespace auhtorization.Data
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
