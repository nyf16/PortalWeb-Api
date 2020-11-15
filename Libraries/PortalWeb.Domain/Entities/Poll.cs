﻿using PortalWeb.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalWeb.Domain.Entities
{
    public class Poll : BaseEntity
    {
        public string Name { get; set; }

        public bool ShowOnHomePage { get; set; }

        public bool AllowGuestsToVote { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual ICollection<PollAnswer> PollAnswers { get; set; }
    }
}
