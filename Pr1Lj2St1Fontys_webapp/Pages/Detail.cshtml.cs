using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pr1Lj2St1Fontys_webapp.Data;
using Pr1Lj2St1Fontys_webapp.Models; // Zorg ervoor dat je de Event-class gebruikt

namespace Pr1Lj2St1Fontys_webapp.Pages
{
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EventModel Event { get; set; }

        public DetailModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id)
        {
            
            Event = await _context.Events.FirstOrDefaultAsync(e => e.EventID == id); // Get events based on EventId

            if (Event == null)
            {
                RedirectToPage("/Error"); // If no event found, can redirect to error page or show a message

            }
        }
    }
}
