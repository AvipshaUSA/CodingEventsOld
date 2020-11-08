using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Models
{


    public class Event
    {
        public string Name { get; set; }

        public Event(string name) // constructor
        {
            Name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
