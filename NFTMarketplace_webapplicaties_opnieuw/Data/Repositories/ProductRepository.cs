using Microsoft.EntityFrameworkCore;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Collections.Generic;
using System.Linq;

namespace NFTMarketplace_webapplicaties_opnieuw.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly NFTMarketplaceContext _context;

        public ProductRepository(NFTMarketplaceContext context)
        {
            _context = context;
        }

        public List<Product> GetProductsForSpecificCollection(Collectie collectie)
        {
            return _context.Producten
                .Where(p => p.CollectieId == collectie.CollectieId)
                .ToList();
        }
    }
}
