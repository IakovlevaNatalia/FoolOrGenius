using Microsoft.EntityFrameworkCore;
using FoolOrGenius.Db.Models;
using FoolOrGenius.DbCore.Models;

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
        public DbSet<Game> Game { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FoolOrGenius; Trusted_Connection=True");
            }
        }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionResult> QuestionResult { get; set; }

        public DbSet<Game2048> Game2048 { get; set; }
        public DbSet<Game2048Type>Game2048Type { get; set; }

    }

   
}
