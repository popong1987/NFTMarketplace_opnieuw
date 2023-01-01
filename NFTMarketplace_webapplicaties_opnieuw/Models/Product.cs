using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public decimal Prijs { get; set; }
        public string Afbeelding { get; set; }
        public string Beschrijving { get; set; }

        [Required]
        public DateTime AanmaakDatum { get; set; }

        [Required]
        public int AantalBeschikbaar { get; set; }

        [Required]

        public int CollectieId { get; set; }


        //navigation properties

        public Collectie Collectie { get; set; }
        public ICollection<ProductProperty> ProductProperties { get; set; }
        public ICollection<OrderProduct> OrderProducten { get; set; }
    }
}
