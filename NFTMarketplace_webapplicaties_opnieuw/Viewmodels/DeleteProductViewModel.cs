using System;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class DeleteProductViewModel
    {
        public int ProductId { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public string Afbeelding { get; set; }
        public string Beschrijving { get; set; }
        public DateTime AanmaakDatum { get; set; }
        public int AantalBeschikbaar { get; set; }
        public int CollectieId { get; set; }
    }
}
