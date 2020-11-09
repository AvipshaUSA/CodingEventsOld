using Microsoft.VisualBasic.CompilerServices;
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
        public string Date;
        public int Id { get; }
        private static int nextId = 1; 
        

    
        public Event(string name, string description, string date) // constructor
        {
            Name = name;
            Description = description;
            Date = date;
            Id = nextId;
            nextId++;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
