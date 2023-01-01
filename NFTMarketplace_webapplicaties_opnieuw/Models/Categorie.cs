using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class Categorie
    {
        public int CategorieId { get; set; }

        [Required]
        public string Naam { get; set; }

        public string Omschrijving { get; set; }

        public ICollection<CollectieCategorie> CollectieCategorieën { get; set; }
    }
}
