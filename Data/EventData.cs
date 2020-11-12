using CodingEvents.Models;// to get Event class from another folder 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Data
{
    public class EventData
    {
        //Store Event
        static private Dictionary<int, Event> Events = new Dictionary<int, Event>();


        // GetAll or Retreive the events


        //Many times there is a need to loop through a collection of classes or lists which are anonymous types. 
        // the Dictionary assigned to different types of values and different types of property in Even class. 
        //To loop thhrough this annonymous type we need to use IEnumerable which is an Interface.
        // IEnumerable interface loop through above collection as:
        public static IEnumerable<Event> GetAll()  
        {
            return Events.Values; // help to get all Values of the dictionary.
        }



        // Add Event
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }


        // Remove an Event
        public static void Remove(int id)
        {
            Events.Remove(id);
        }

        // GetById , retrive a single Event
        public static Event GetById(int id) // return type is Event Class
        {
            
            return Events[id]; // it will get the values assosiated with the id key. dictionary[key] returns corresponding Value.
        }

    }
}
