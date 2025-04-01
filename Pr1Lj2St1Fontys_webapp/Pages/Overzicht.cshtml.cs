using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pr1Lj2St1Fontys_webapp.Data;
using Pr1Lj2St1Fontys_webapp.Models; // This namespace to have connection to DbContext

namespace Pr1Lj2St1Fontys_webapp.Pages
{
    public class OverzichtModel : PageModel
    {
        private readonly ApplicationDbContext _context; // Database context to access the database

        public IEnumerable<EventModel> Evenementen { get; set; } // List of EventModel objects to store the events retrieved from the database

        public OverzichtModel(ApplicationDbContext context) // Constructor to get the database context injected into this class
        {
            _context = context;
        }

        public void OnGet()
        {
            // Retrieve only future events from the database
            Evenementen = _context.Events // Access the Events table in the database
                .AsNoTracking() // No tracking of objects, because we only read from the database and don't change anything also optimizes performance
                .Where(e => e.StartDatumTijd > DateTime.Now) // Only upcoming events
                .OrderBy(e => e.StartDatumTijd) // Sort ascending
                .ToList(); // Executes query and stores results in a list of EventModel objects 
        }
        //SELECT* FROM Evenementen
        //WHERE StartDatumTijd > GETDATE()
        //ORDER BY StartDatumTijd;

    }
}

