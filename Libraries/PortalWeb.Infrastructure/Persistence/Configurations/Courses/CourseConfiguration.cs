﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalWeb.Domain.Common;
using PortalWeb.Domain.Entities;

namespace PortalWeb.Infrastructure.Persistence.Configurations.Courses
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
            builder.Property(s => s.ShortDescription).IsRequired().HasMaxLength((int)MaxLengthSize.ShortDescription);
            builder.Property(s => s.MetaTitle).IsRequired().HasMaxLength((int)MaxLengthSize.MetaTitle);
            builder.Property(s => s.MetaDescription).IsRequired().HasMaxLength((int)MaxLengthSize.MetaDescription);
            builder.Property(s => s.MetaKeywords).IsRequired().HasMaxLength((int)MaxLengthSize.MetaDescription);
        }
    }
}