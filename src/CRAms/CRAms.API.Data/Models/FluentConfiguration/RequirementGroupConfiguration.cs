using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRAms.API.Data.Models.FluentConfiguration
{
    internal class RequirementGroupConfiguration : NamedEntityConfiguration<RequirementGroup>
    {
        public override void Configure(EntityTypeBuilder<RequirementGroup> builder)
        {
            base.Configure(builder);

            builder.ToTable("RequirementGroups");
            builder.HasMany(rg => rg.Items).WithOne(i => i.RequirementGroup).HasForeignKey(i => i.RequirementGroupId);
            builder.HasOne(rg => rg.TechnicalGuideline).WithMany(tg => tg.RequirementGroups).HasForeignKey(rg => rg.TechnicalGuidelineId);
        }
    }
}
