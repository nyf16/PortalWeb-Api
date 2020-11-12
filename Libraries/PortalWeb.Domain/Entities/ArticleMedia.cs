using System;
using System.Collections.Generic;
using System.Text;

namespace PortalWeb.Domain.Entities
{
    public class ArticleMedia
    {
        public int ArticleId { get; set; }

        public Article Article { get; set; }

        public int MediaId { get; set; }

        public Media Media { get; set; }
    }
}
