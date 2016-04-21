using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrams
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }

        public int StateId { get; set; }
        public virtual State State { get; set; }

    }
}