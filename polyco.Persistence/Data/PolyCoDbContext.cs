
using Microsoft.EntityFrameworkCore;
using polyco.Domain.Entities;

namespace polyco.Persistence.Data
{
    public class PolyCoDbContext : DbContext
    {
        public PolyCoDbContext(DbContextOptions<PolyCoDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
