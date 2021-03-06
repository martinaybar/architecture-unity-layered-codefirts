﻿using System.Collections.Generic;

namespace Entities
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection <User> Users { get; set; }

    }
}
