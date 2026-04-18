using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRAms.Data.Models.FluentConfiguration
{
    internal sealed class RequirementConfiguration : NamedEntityConfiguration<Requirement>
    {
        public override void Configure(EntityTypeBuilder<Requirement> builder)
        {
            base.Configure(builder);

            builder.ToTable("Requirements");

            builder
                .HasOne(r => r.ParentRequirement)
                .WithMany(r => r.SubRequirements)
                .HasForeignKey(r => r.ParentRequirementId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
