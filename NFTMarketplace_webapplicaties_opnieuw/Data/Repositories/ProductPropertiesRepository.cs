using Microsoft.EntityFrameworkCore;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Collections.Generic;
using System.Linq;

namespace NFTMarketplace_webapplicaties_opnieuw.Data.Repositories
{
    public class ProductPropertiesRepository: IProductPropertiesRepository
    {
        private readonly NFTMarketplaceContext _context;

        public ProductPropertiesRepository(NFTMarketplaceContext context)
        {
            _context = context;
        }

        public List<ProductProperty> GetPropertiesForSpecificProduct(Product product)
        {
            return _context.productProperties
                    .Include(p => p.Property)
                    .Where(pp => pp.ProductId == product.ProductId)
                    .ToList();
        }
    }
}
