using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InlamningASP1.Models;


namespace InlamningASP1.Data
{
    public class EventContext : DbContext
    {
        public EventContext (DbContextOptions<EventContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Event { get; set; }
    public void Seed()
        {
            this.Database.EnsureCreated();
            if(this.Event.Any())
            {
                return;
            }

            Event.AddRange(new List<Event>()
            {
                new Event() { Title="Alicia Keys", Description="Music", Place="Ericsson Globe", Adress="Stockholm", Date="20210615",  SpotsAvailable=15 },
                 new Event() { Title="CS:Go Major", Description="E-sport", Place="Ericsson Globe", Adress="Stockholm", Date="20211107",  SpotsAvailable=10 },
                  new Event() { Title="Sweden International Horse Show", Description="Horse show", Place="Ericsson Globe", Adress="Stockholm", Date="20211126",  SpotsAvailable=33 },
                   new Event() { Title="GAIS - BK Häcken", Description="Soccer", Place="Ullevi", Adress="Gothenburg", Date="20210508",  SpotsAvailable=27},
                    new Event() { Title="Iron Maiden", Description="Music", Place="Ullevi", Adress="Gothenburg", Date="20210703",  SpotsAvailable=5 }
            }) ;
            this.SaveChanges();
        }
    }
}

/*
 *    public int EventId { get; set; }  // PK
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public string Date { get; set; }
        public int SpotsAvailable { get; set; }
        public  List<Attendee> Attendees { get; set; } // FK (many)
        public  List<Organizer> Organizers { get; set; } // FK (many)
    }
 * 
 */