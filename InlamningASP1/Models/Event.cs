using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlamningASP1.Models
{
    public class Event
    {
        public int EventId { get; set; }  // PK
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public string Date { get; set; }
        public int SpotsAvailable { get; set; }
        public  List<Attendee> Attendees { get; set; } // FK (many)
        public Organizer Organizer { get; set; } //FK (One)
  
    }
}
