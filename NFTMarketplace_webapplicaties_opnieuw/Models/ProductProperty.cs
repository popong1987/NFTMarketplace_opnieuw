using System.ComponentModel.DataAnnotations;

namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class ProductProperty
    {
        public int ProductPropertyId { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        public int ProductId { get; set; }

        //navigation properties
        public Property Property { get; set; }
        public Product Product { get; set; }
    }
}
