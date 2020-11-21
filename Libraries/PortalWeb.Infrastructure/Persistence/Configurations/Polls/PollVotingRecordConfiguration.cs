using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalWeb.Domain.Entities;

namespace PortalWeb.Infrastructure.Persistence.Configurations.Polls
{
    public class PollVotingRecordConfiguration : IEntityTypeConfiguration<PollVotingRecord>
    {
        public void Configure(EntityTypeBuilder<PollVotingRecord> builder)
        {
            builder.Property(s => s.PollId).IsRequired();
            builder.Property(s => s.PollAnswerId).IsRequired();
        }
    }
}