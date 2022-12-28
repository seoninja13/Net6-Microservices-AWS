using Microsoft.EntityFrameworkCore;

namespace Clodweather.Temperature.DataAccess
{
    public class TemperatureDbContext : DbContext
    {
        public TemperatureDbContext()
        {

        }

        public TemperatureDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Temperature> Temperature { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SnakeCaseIdentityTableName(modelBuilder);
        }

        private void SnakeCaseIdentityTableName(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Temperature>(b => { b.ToTable("temperature"); });
        }
    }
}

