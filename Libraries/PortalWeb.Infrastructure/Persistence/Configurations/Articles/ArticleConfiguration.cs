using Microsoft.EntityFrameworkCore;
using PortalWeb.Domain.Common;
using PortalWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalWeb.Infrastructure.Persistence.Configurations.Articles
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Article> builder)
        {
            builder.Property(s => s.Title).IsRequired().HasMaxLength((int)MaxLengthSize.Title);
            builder.Property(s => s.ShortDescription).IsRequired().HasMaxLength((int)MaxLengthSize.ShortDescription);
            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
        }
    }
}
