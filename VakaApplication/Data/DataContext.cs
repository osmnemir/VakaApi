using Microsoft.EntityFrameworkCore;
using VakaApplication.Models;

namespace VakaApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
