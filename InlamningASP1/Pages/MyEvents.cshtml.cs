using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InlamningASP1.Data;
using InlamningASP1.Models;

namespace InlamningASP1.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly EventContext _context;

        public MyEventsModel(EventContext context)
        {
            _context = context;
        }

        public Attendee Attendee { get;set; }

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendee.Where(a =>a.AttendeeId == 1)
            .Include(e => e.Events)
             .FirstOrDefaultAsync();
           
        }
    
    }
 
}
