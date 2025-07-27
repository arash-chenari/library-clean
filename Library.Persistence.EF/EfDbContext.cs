using Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Persistence.EF
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDbContext).Assembly);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
