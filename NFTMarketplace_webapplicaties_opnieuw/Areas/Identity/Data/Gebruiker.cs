using Microsoft.AspNetCore.Identity;
using System;

namespace NFTMarketplace_webapplicaties_opnieuw.Areas.Identity.Data
{
    public class Gebruiker: IdentityUser
    {
        [PersonalData]
        public string Naam { get; set; }

        [PersonalData]
        public DateTime Geboortedatum { get; set; }
    }
}
