using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalWeb.Domain.Common;
using PortalWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalWeb.Infrastructure.Persistence.Configurations.Courses
{
    public class CourseLessonConfiguration : IEntityTypeConfiguration<CourseLesson>
    {
        public void Configure(EntityTypeBuilder<CourseLesson> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
            builder.Property(s => s.ShortDescription).IsRequired().HasMaxLength((int)MaxLengthSize.ShortDescription);
        }

    }
}
