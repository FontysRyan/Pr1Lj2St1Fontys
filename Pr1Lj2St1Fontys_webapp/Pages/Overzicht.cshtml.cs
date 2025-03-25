using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pr1Lj2St1Fontys_webapp.Data;
using Pr1Lj2St1Fontys_webapp.Models; // This namespace to have connection to DbContext

namespace Pr1Lj2St1Fontys_webapp.Pages
{
    public class OverzichtModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IEnumerable<EventModel> Evenementen { get; set; }

        public OverzichtModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            // Haal de evenementen uit de database
            Evenementen = _context.Events.AsNoTracking().ToList(); // Gebruik EventModel voor Evenementen
        }
    }
}

