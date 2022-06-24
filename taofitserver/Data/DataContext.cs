using Microsoft.EntityFrameworkCore;

namespace taofitserver.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Food> Foods { get; set; }
    } 
}
