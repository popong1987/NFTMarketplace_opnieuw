using System.ComponentModel.DataAnnotations;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class CreateOrderViewModel
    {
        public int OrderId { get; set; }

        [Required]
        public decimal TotalePrijs { get; set; }


        public string GebruikerId { get; set; }
    }
}
