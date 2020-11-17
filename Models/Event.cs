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
        public string ContactEmail { get; set; }
        public string EventLocation { get; set; }
        public int NumberOfAtendee { get; set; }
        public bool Register { get; set; } 
        public bool IsTrue { get { return true; } }


        public int Id { get; }
        private static int nextId = 1; 
        

    public Event()
        {
            Id = nextId;
            nextId++;
        }

        public Event(string name, string description, string date, string contactEmail, string eventLocation, int numberOfAtendee, bool register) : this()// constructor
        {
            Name = name;
            Description = description;
            Date = date;
            ContactEmail = contactEmail;
            EventLocation = eventLocation;
            NumberOfAtendee = numberOfAtendee;
            Register = register;
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
