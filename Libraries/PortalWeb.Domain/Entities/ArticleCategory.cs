﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PortalWeb.Domain.Entities
{
    public class ArticleCategory
    {
        public int ArticleId { get; set; }

        public Article Article { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
