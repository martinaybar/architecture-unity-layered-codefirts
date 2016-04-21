using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrams
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<State> States { get; set; }
        
    }
}