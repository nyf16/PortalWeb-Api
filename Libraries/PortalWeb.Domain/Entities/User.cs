using PortalWeb.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalWeb.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
