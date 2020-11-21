using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalWeb.Domain.Common;
using PortalWeb.Domain.Entities;

namespace PortalWeb.Infrastructure.Persistence.Configurations.Medias
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.Property(s => s.FileName).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(s => s.Caption).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(s => s.MediaType).IsRequired();
        }
    }
}