using Microsoft.EntityFrameworkCore;
using UserData.EntityConfigurations;
using UserDomain.AggregateModels;

namespace UserData
{
    public class UserContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "users";
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}