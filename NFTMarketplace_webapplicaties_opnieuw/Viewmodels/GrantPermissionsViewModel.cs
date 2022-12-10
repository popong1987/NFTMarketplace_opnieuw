using Microsoft.AspNetCore.Mvc.Rendering;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class GrantPermissionsViewModel
    {
        public SelectList Gebruikers { get; set; }
        public SelectList Rollen { get; set; }
        public string GebruikerId { get; set; }
        public string RolId { get; set; }
    }
}
