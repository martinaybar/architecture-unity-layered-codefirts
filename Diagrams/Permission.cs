using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrams
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Name { get; set; }


        public virtual ICollection<UserType> UserTypes { get; set; }

    }
}