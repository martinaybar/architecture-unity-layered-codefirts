using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int Name { get; set; }

        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
