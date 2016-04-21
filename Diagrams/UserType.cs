using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrams
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }

    }

}