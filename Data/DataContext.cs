using AspNetCaNhan.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCaNhan.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
