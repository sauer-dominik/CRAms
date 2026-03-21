using CRAms.API.Data.Models;
using CRAms.API.Data.Models.FluentConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CRAms.API.Data
{
    public class CRAmsDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<RequirementGroup> RequirementGroups { get; set; }
        public DbSet<TechnicalGuideline> TechnicalGuidelines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // EntityConfiguration and NamedEntityConfiguration will not be applied here
            // since they are already included by calling base configuration inside Entities
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new RequirementGroupConfiguration());
            modelBuilder.ApplyConfiguration(new TechnicalGuidelineConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
