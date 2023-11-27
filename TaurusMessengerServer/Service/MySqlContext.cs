using TaurusMessenger.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace TaurusMessengerServer.Service
{
    public class MySqlContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public MySqlContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=12348035;database=taurus;",
                new MySqlServerVersion(new Version(8, 0, 35)));
        }
    }
}
    