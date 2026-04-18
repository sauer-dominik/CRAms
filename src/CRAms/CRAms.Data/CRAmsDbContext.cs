using CRAms.Data.Models.FluentConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CRAms.Data
{
    public class CRAmsDbContext : DbContext
    {
        public CRAmsDbContext(DbContextOptions<CRAmsDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // EntityConfiguration and NamedEntityConfiguration will not be applied here
            // since they are already included by calling base configuration inside Entities
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new ItemTaskConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RequirementConfiguration());
            modelBuilder.ApplyConfiguration(new TechnicalGuidelineConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
