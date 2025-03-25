using System;
using System.ComponentModel.DataAnnotations;

namespace Pr1Lj2St1Fontys_webapp.Models
{
    public class EventModel
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        public string Activiteit { get; set; }

        public string Beschrijving { get; set; }
        public string Benodigdheden { get; set; }

        [Required]
        public DateTime StartDatumTijd { get; set; }

        [Required]
        public DateTime EindDatumTijd { get; set; }

        public string Locatie { get; set; }
        public string AfbeeldingURL { get; set; }
    }

}
