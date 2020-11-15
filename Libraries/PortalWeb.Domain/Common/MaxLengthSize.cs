using System;
using System.Collections.Generic;
using System.Text;

namespace PortalWeb.Domain.Common
{
    public enum MaxLengthSize
    {
        Title = 300,
        ShortDescription = 450,
        Description = 1500,
        Name = 150,
        EmailAddress = 150,
        MetaTitle = 160,
        MetaDescription = 255,
        MetaKeywords = 255,
        PhoneNumber = 50
    }
}
