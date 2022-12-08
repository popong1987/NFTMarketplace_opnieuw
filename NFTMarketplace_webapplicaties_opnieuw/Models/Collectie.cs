using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class Collectie
    {
        public int CollectieId { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public DateTime AanmaakDatum { get; set; }

        [Required]
        public double CreatorFee { get; set; }

        [Required]
        public string Beschrijving { get; set; }

        public string Afbeelding { get; set; }

        //navigation properties

        public ICollection<Product> Producten { get; set; }
        public ICollection<CollectieCategorie> CollectieCategorieën { get; set; }
        public ICollection<CollectieCreator> CollectieCreators { get; set; }
    }
}
