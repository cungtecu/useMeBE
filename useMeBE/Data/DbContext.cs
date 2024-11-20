using Microsoft.EntityFrameworkCore;
using useMeBE.Models;

namespace useMeBE.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) 
        { 

        }

        public DbSet<User> Users { get; set; } 
        public DbSet<Tables> Tables { get; set; } 
    }
}
