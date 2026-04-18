using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRAms.Data.Models.FluentConfiguration
{
    internal sealed class ItemTaskConfiguration : EntityConfiguration<ItemTask>
    {
        public override void Configure(EntityTypeBuilder<ItemTask> builder)
        {
            base.Configure(builder);

            builder.ToTable("ItemTasks");
        }
    }
}
