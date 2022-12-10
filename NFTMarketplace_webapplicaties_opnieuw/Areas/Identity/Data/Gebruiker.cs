using Microsoft.AspNetCore.Identity;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using System;
using System.Collections.Generic;

namespace NFTMarketplace_webapplicaties_opnieuw.Areas.Identity.Data
{
    public class Gebruiker: IdentityUser
    {
        [PersonalData]
        public string Naam { get; set; }

        [PersonalData]
        public DateTime Geboortedatum { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
