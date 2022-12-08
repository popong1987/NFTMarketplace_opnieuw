using System.ComponentModel.DataAnnotations;

namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class CollectieCategorie
    {
        public int CollectieCategorieId { get; set; }


        [Required]
        public int CollectieId { get; set; }

        [Required]
        public int CategorieId { get; set; }

        //navigation properties
        public Collectie Collectie { get; set; }
        public Categorie Categorie { get; set; }
    }
}
