using CalcLactase.Dominio;
using Microsoft.EntityFrameworkCore;

namespace CalcLactase.Repository
{
    public class CalcLactaseContext : DbContext
    {
        public CalcLactaseContext(DbContextOptions<CalcLactaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Product> Product { get; set; }
    }
}
