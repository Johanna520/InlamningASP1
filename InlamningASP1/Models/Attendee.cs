using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlamningASP1.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; } // PK
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public  List<Event> Events { get; set; } // FK (many)
    }
}
