using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRAms.API.Data.Models.FluentConfiguration
{
    internal class NamedEntityConfiguration<TEntity> : EntityConfiguration<TEntity>
        where TEntity : NamedEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.Property(ne => ne.Name).IsRequired();
        }
    }
}
