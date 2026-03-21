using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRAms.API.Data.Models.FluentConfiguration
{
    internal class ItemConfiguration : EntityConfiguration<Item>
    {
        public override void Configure(EntityTypeBuilder<Item> builder)
        {
            base.Configure(builder);

            builder.ToTable("Items");
            builder.Property(i => i.Description).IsRequired();
            builder.HasOne(i => i.RequirementGroup).WithMany(rg => rg.Items).HasForeignKey(i => i.RequirementGroupId);
            builder.Property(i => i.Type).IsRequired();
        }
    }
}
