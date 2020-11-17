using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.ViewModel
{
    public class AddEventviewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3 and 50 charecters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public string Date { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Location name is required.")]
        [Display(Name = "Events Location")]
        public string EventLocation { get; set; }

        [Required(ErrorMessage = "Number of attendee  is required.")]
        [Display(Name = "Number of Attendees")]
        [Range(0, 10, ErrorMessage = "Name must be 0 and 10 charecters.")]
        public int NumberOfAtendee { get; set; }

      
        [Compare(nameof(IsTrue), ErrorMessage = "Registration Required. Please Check the Box")]
        public bool Register { get; set; }

        
        public bool IsTrue { get { return true; } }
    }
}
