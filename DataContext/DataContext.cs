using Microsoft.EntityFrameworkCore;
using DemoLoginAPI.Students;

namespace DemoLoginAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<StudentsEntity> Students { get; set; }
    }
}