using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Collections.Generic;
using System;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class CollectieDetailsViewModel
    {
        public int CollectieId { get; set; }
        public string Naam { get; set; }
        public DateTime AanmaakDatum { get; set; }
        public double CreatorFee { get; set; }
        public string Beschrijving { get; set; }
        public string Afbeelding { get; set; }

        public List<Product> Producten { get; set; }
    }
}
