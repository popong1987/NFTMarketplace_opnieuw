using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public decimal TotalePrijs { get; set; }


        public int GebruikerId { get; set; }

        //navigation properties

        public List<OrderProduct> OrderProducten { get; set; }
        /*public Gebruiker Gebruiker { get; set; }*/
    }
}
