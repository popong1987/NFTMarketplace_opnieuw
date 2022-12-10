using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class OrderOverviewViewModel
    {
        public int OrderId { get; set; }
        public decimal TotalePrijs { get; set; }


        public string GebruikerId { get; set; }

        public bool IsWinkelmandje { get; set; }
        public List<OrderProduct> OrderProducten { get; set; }

    }
}
