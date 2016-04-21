using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrams
{
    public class State
    {
        public int StateId { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}