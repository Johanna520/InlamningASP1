using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlamningASP1.Models
{
    public class Organizer 
    {
        public int OrganizerId { get; set; } // PK
        public string Name { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public Event Event{ get; set;  } //FK (One)
    }
}
