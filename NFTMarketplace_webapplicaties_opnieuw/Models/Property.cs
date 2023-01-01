using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class Property
    {
        public int PropertyId { get; set; }

        [Required]
        public string Naam { get; set; }
        public int Schaarsheid { get; set; }

        //navigation properties

        public ICollection<ProductProperty> ProductProperties { get; set; }
    }
}
