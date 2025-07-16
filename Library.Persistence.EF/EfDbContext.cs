using Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Persistence.EF
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions options) : base(options) { }


        public DbSet<Category> Categories { get; set; }
    }
}
