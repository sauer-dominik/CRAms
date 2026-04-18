using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRAms.Data.Models.FluentConfiguration
{
    internal sealed class ItemConfiguration : EntityConfiguration<Item>
    {
        public override void Configure(EntityTypeBuilder<Item> builder)
        {
            base.Configure(builder);

            builder.ToTable("Items");
            builder.Property(i => i.Description).IsRequired();
            // builder.HasOne(i => i.RequirementGroup).WithMany(rg => rg.Items).HasForeignKey(i => i.RequirementGroupId);
            builder.HasOne(i => i.Requirement).WithMany(r => r.RequirementItems).HasForeignKey(i => i.RequirementId);
            builder.Property(i => i.Type).IsRequired();
        }
    }
}
