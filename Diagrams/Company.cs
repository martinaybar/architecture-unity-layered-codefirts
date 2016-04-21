using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrams
{
    public class Company
    {
        public int CompanyId { get; set; }

        //Razon Social
        public string LegalName { get; set; }
        public string CUIT { get; set; }
        //Nombre de fantasia
        public string Name { get; set; }
        public string Url { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }

        public virtual CompanyCategory Category { get; set; }
        public virtual CompanyStatistic CompanyStatistics { get; set; }



    }
}