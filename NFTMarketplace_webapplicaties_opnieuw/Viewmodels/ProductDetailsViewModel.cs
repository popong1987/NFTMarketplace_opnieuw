using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Collections.Generic;
using System;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class ProductDetailsViewModel
    {
        public int ProductId { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public string Afbeelding { get; set; }
        public string Beschrijving { get; set; }
        public DateTime AanmaakDatum { get; set; }
        public int AantalBeschikbaar { get; set; }
        public int CollectieId { get; set; }

        public Collectie Collectie { get; set; }
        public List<ProductProperty> ProductProperties { get; set; }
        public List<OrderProduct> OrderProducten { get; set; }
    }
}
