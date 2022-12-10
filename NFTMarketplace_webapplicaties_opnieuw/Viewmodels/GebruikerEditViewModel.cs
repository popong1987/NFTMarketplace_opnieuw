using System.ComponentModel.DataAnnotations;
using System;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class GebruikerEditViewModel
    {
        public string GebruikerId { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]

        public DateTime Geboortedatum { get; set; }
        [Required]
        public string Email { get; set; }


    }
}
