using NFTMarketplace_webapplicaties_opnieuw.Models;
using System;
using System.Collections.Generic;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class GebruikerDeleteViewModel
    {
        public string GebruikerId { get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
