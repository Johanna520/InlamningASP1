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
        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Attendee> Attendee { get; set; }

        public void Seed()
        {
            this.Database.EnsureCreated();
            if (this.Event.Any())
            {
                return;
            }

            this.RemoveRange(this.Event);
            this.RemoveRange(this.Organizer);
            this.RemoveRange(this.Attendee);

          
            var Organizer = new Organizer[]
            {
                new Organizer() { Name="Live Nation", Title="Concert", PhoneNumber="0812568743" },
                new Organizer() { Name="Sweden International Horse Show", Title="Horse Show", PhoneNumber="054686145" },
                new Organizer() { Name="PGL Esports SRL", Title="E-sport", PhoneNumber="054686445" },
                new Organizer() { Name="GAIS", Title="Soccer", PhoneNumber="256032154" }
            };

             var Attendee = new Attendee[]
             {
                new Attendee() { Name="Johanna", Email="johanna@gmail.com", PhoneNumber="0765411644" }
             };
   
                   var Event = new Event[]
            {
                new Event() { Title="Alicia Keys", Description="Music", Place="Ericsson Globe", Adress="Stockholm", Date="20210615",  SpotsAvailable=15, Organizer=Organizer[0] },
                 new Event() { Title="CS:Go Major", Description="E-sport", Place="Ericsson Globe", Adress="Stockholm", Date="20211107",  SpotsAvailable=10, Organizer=Organizer[2]  },
                  new Event() { Title="Sweden International Horse Show", Description="Horse show", Place="Ericsson Globe", Adress="Stockholm", Date="20211126",  SpotsAvailable=33, Organizer=Organizer[1] },
                   new Event() { Title="GAIS - Öster IF", Description="Soccer", Place="Ullevi", Adress="Gothenburg", Date="20210504",  SpotsAvailable=27, Organizer=Organizer[3]},
                    new Event() { Title="Iron Maiden", Description="Music", Place="Ullevi", Adress="Gothenburg", Date="20210703",  SpotsAvailable=5, Organizer=Organizer[0]}
            };

            this.Attendee.AddRange(Attendee);
            this.Organizer.AddRange(Organizer);
            this.Event.AddRange(Event);
            this.SaveChanges();
        }
    }
}

