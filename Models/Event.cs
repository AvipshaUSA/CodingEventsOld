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
        public string Date { get; set; }
      
        public int Id { get; }
        private static int nextId = 1; 
        

    public Event()
        {
            Id = nextId;
            nextId++;
        }

        public Event(string name, string description, string date) : this()// constructor
        {
            Name = name;
            Description = description;
            Date = date;
           
           
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
