using Microsoft.EntityFrameworkCore;
using DemoLoginAPI.Students;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DemoLoginAPI
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<StudentsEntity> Students { get; set; }
    }
}