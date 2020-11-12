using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CodingEvents.Models;  // used because Event data type is list below is in different folder. so we import.
using Microsoft.VisualBasic.CompilerServices;
using CodingEvents.Data; // used because we need to import EventData from Data/EventData.cs

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {

        //static private List<Event> Events = new List<Event>();

        
        //GET: /<controller> /

        [HttpGet] // we want index only response to the get method on localhost 5001/events.
        public IActionResult Index()
        {

           

            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult AddEvents() // this addEvents() action method going to responds to getRequest at the localhost 5001/addevents
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/AddEvents")]
        public IActionResult NeWevent(Event newEvent) // this argument names are comming from Events/Addevent.cshtml 's.
                                                                             //we declared the names of input as name and description
        {
            
                EventData.Add(newEvent); // Add method from Data/Eventdata.cd has one argument. so here we pass new Event(name, description, date) as an argument.

            return Redirect("/Events"); // redirect to action method
        }


        
        
        public IActionResult DeleteEvents()

        {

            ViewBag.events = EventData.GetAll(); // we want to display the user what we have in list
           return View();
          
        }
        [HttpPost]
        public IActionResult DeleteEvents(int[] eventIds) // create method in the same name of above to post the delete.
        {
            foreach (var eventId in eventIds)
            {
                EventData.Remove(eventId);
            }
            return Redirect("/Events");
        }



        [Route("/Events/Edit/{eventId}")] // this rout will take us to  the selected id no 
        public IActionResult Edit(int eventId)
        {

            ViewBag.eventsDictionaryObj = EventData.GetById(eventId);// picking the value which is a class type List, corresponding to the Id.
            ViewBag.title = "You are editing " + ViewBag.eventsDictionaryObj.Name + " (id= #" + ViewBag.eventsDictionaryObj.Id + ")"; 
            // controller code will go here
            return View();
        }


        [HttpPost]
        [Route("/events/edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description, string date)
        {

            Event updated = EventData.GetById(eventId);  // Event is class type list and a Value od Events dictionary. 
                                                            //so to get that Event List value which is acctualy a class type ,we need to create an object of Event Class.

            //updating the fields
            updated.Name = name;
            updated.Description = description;
            // controller code will go here
            return Redirect("/Events");
        }

    }
}
