using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IMC.Domain;

namespace IMC.Infrastructure.Persistence.Configurations
{
    internal class PaintConfiguration : IEntityTypeConfiguration<Paint>
    {
        public void Configure(EntityTypeBuilder<Paint> builder)
        {
            builder.HasKey(paint => paint.Id);
            builder.HasIndex(paint => paint.Id).IsUnique();
            builder.Property(paint => paint.Title).HasMaxLength(250);
        }

    }
}
