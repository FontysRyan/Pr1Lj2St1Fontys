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
            // Haal het evenement op op basis van EventID
            Event = await _context.Events.FirstOrDefaultAsync(e => e.EventID == id);

            if (Event == null)
            {
                // Als het evenement niet gevonden is, kun je een 404-pagina tonen of een andere logica toevoegen
                RedirectToPage("/Error");
            }
        }
    }
}
