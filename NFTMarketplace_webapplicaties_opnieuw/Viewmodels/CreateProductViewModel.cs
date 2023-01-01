using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Http;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class CreateProductViewModel
    {
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public string Afbeelding { get; set; }
        public string Beschrijving { get; set; }
        public DateTime AanmaakDatum { get; set; }
        public int AantalBeschikbaar { get; set; }
        public int CollectieId { get; set; }
        public List<IFormFile> PostedFiles { get; set; }
        
    }
}