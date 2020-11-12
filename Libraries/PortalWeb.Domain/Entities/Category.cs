using PortalWeb.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalWeb.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public Category Parent { get; set; }
    }
}
