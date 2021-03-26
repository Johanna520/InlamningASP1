using InlamningASP1.Data;
using InlamningASP1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

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
            if (id == null)
            {
                return NotFound();
            }
            var attendee = await _context.Attendee.Where(a => a.AttendeeId == 1)
             .Include(e => e.Events)
             .FirstOrDefaultAsync();

            Event = await _context.Event.FirstOrDefaultAsync(m => m.EventId == id);
            attendee.Events.Add(Event);

            await _context.SaveChangesAsync();

            return Page();

           
        }
    }
}
