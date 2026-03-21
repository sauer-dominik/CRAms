using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRAms.API.Data.Models.FluentConfiguration
{
    internal class TechnicalGuidelineConfiguration : EntityConfiguration<TechnicalGuideline>
    {
        public override void Configure(EntityTypeBuilder<TechnicalGuideline> builder)
        {
            base.Configure(builder);

            builder.Property(tg => tg.Version).IsRequired();
            builder.HasMany(tg => tg.RequirementGroups).WithOne(rg => rg.TechnicalGuideline);
        }
    }
}
