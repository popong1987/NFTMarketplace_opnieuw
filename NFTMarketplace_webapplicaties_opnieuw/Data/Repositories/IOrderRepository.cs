using NFTMarketplace_webapplicaties_opnieuw.Areas.Identity.Data;
using NFTMarketplace_webapplicaties_opnieuw.Models;

namespace NFTMarketplace_webapplicaties_opnieuw.Data.Repositories
{
    public interface IOrderRepository
    {
        public Order findSpecificOrder(Gebruiker gebruiker);
    }
}
