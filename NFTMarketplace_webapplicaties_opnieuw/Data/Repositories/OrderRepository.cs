using Microsoft.EntityFrameworkCore;
using NFTMarketplace_webapplicaties_opnieuw.Areas.Identity.Data;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Collections;
using System.Linq;

namespace NFTMarketplace_webapplicaties_opnieuw.Data.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly NFTMarketplaceContext _context;

        public OrderRepository(NFTMarketplaceContext context)
        {
            _context = context;
        }
        
        public Order findSpecificOrder(Gebruiker gebruiker)
        {
            return _context.Orders.Where(o => o.GebruikerId == gebruiker.Id && o.IsWinkelmandje == true).FirstOrDefault();
        }
        
    }
}
