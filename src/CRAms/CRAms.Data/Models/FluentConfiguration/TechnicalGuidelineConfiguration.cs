using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRAms.Data.Models.FluentConfiguration
{
    internal sealed class TechnicalGuidelineConfiguration : EntityConfiguration<TechnicalGuideline>
    {
        public override void Configure(EntityTypeBuilder<TechnicalGuideline> builder)
        {
            base.Configure(builder);

            builder.Property(tg => tg.LanguageName).IsRequired();
            builder.Property(tg => tg.Version).IsRequired();
            builder.HasIndex(tg => new { tg.LanguageName, tg.Version });

            // builder.HasMany(tg => tg.RequirementGroups).WithOne(rg => rg.TechnicalGuideline);
            builder
                .HasMany(tg => tg.ParentRequirements)
                .WithOne(r => r.TechnicalGuideline)
                .HasForeignKey(r => r.TechnicalGuidelineId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
