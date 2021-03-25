﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InlamningASP1.Data;
using InlamningASP1.Models;
using System.Diagnostics;

namespace InlamningASP1.Pages
{
    public class JoinEventsModel : PageModel
    {
        private readonly EventContext _context;

        public JoinEventsModel(EventContext context)
        {
            _context = context;
        }
     
        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.EventId == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
        [BindProperty]
        public Event newEvents { get; set; }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
      

            newEvents.Organizer = await _context.Organizer.FirstOrDefaultAsync(m => m.OrganizerId == id);


            await _context.AddAsync(newEvents);
            await _context.SaveChangesAsync();

            Event = await _context.Event.FirstOrDefaultAsync(m => m.EventId == id);
            return Page();
        }
    }
}
