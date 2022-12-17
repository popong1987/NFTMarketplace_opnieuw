using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Collections.Generic;

namespace NFTMarketplace_webapplicaties_opnieuw.Data.Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetProductsForSpecificCollection(Collectie collectie);
    }
}
