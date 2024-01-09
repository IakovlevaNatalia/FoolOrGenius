using Microsoft.EntityFrameworkCore;
using FoolOrGenius.Db.Models;

namespace FoolOrGenius.Db
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base (options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> User { get; set; }

    }
}
