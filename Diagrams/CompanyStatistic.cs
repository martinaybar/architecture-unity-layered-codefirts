using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrams
{
    public class CompanyStatistic
    {
        public int CompanyStatisticId { get; set; }
        public float ChangedTotal { get; set; }
        public float InvestedTotal { get; set; }
        public int ActiveOffers { get; set; }
        
        public Company Company { get; set; }




    }
}