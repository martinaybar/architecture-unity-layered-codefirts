using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public int Name { get; set; }


        //TODO Delete
        public virtual ICollection<User> Users { get; set; }
    }
}
