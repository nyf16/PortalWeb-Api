using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalWeb.Domain.Common;
using PortalWeb.Domain.Entities;

namespace PortalWeb.Infrastructure.Persistence.Configurations.Comments
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(s => s.ArticleId).IsRequired();
            builder.Property(s => s.CommentText).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
            builder.Property(s => s.CommenterName).IsRequired().HasMaxLength((int)MaxLengthSize.EmailAddress);
            builder.Property(s => s.CommenterEmail).IsRequired().HasMaxLength((int)MaxLengthSize.EmailAddress);
        }
    }
}