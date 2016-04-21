using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class ProductTypeMapping: EntityTypeConfiguration<ProductType>
    {
        public ProductTypeMapping()
        {
            // Especificar el nombre de una tabla.
            this.Map(m => m.ToTable("ProductTypes"));

        }

    }
}
