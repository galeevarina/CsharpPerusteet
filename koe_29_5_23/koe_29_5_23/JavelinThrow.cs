using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koe_29_5_23
{
    class JavelinThrow
    {
        public int Id { get; set; }
        public string AthleteName { get; set; }
        public int Meters { get; set; }
        public int Centimeters { get; set; }

        public JavelinThrow (int id, string athleteName, int meters, int centimeters)
        { 
            Id = id;
            AthleteName = athleteName;
            Meters = meters;
            Centimeters = centimeters;
        }

    }
}
