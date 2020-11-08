using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Models
{


    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Event(string name, string description) // constructor
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
