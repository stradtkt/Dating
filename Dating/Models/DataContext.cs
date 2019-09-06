using Microsoft.EntityFrameworkCore;

namespace Dating.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values {get;set;}
    }
}