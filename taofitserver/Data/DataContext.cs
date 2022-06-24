using Microsoft.EntityFrameworkCore;
using taofitserver.Data.Models;

namespace taofitserver.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; } 
    } 
}
