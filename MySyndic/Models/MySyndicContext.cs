using Microsoft.EntityFrameworkCore;

namespace MySyndic.Models
{
    public class MySyndicContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString: @"server=localhost;port=15000;database=MySyndic;uid=reivax;password=azerty123;",
                new MySqlServerVersion(new Version(8, 0, 31)));
        }

        public DbSet<CoOwner> CoOwner { get; set; }
    }
}
