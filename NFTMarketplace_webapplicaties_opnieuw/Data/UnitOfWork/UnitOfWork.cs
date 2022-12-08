using NFTMarketplace_webapplicaties_opnieuw.Data.Repositories;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly NFTMarketplaceContext _context;
        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<ProductProperty> _productPropertyRepository;
        private IGenericRepository<Collectie> _collectieRepository;
        private IGenericRepository<Order> _orderRepository;
        private IGenericRepository<OrderProduct> _orderProductRepository;

        public UnitOfWork(NFTMarketplaceContext context)
        {
            _context = context;

        }

        public IGenericRepository<Product> ProductRepository
        {
            get
            {
                if (this._productRepository == null)
                {
                    this._productRepository = new GenericRepository<Product>(_context);
                }
                return _productRepository;
            }
        }

        public IGenericRepository<ProductProperty> ProductPropertyRepository
        {
            get
            {
                if (this._productPropertyRepository == null)
                {
                    this._productPropertyRepository = new GenericRepository<ProductProperty>(_context);
                }
                return _productPropertyRepository;
            }
        }
        public IGenericRepository<Collectie> CollectieRepository
        {
            get
            {
                if (this._collectieRepository == null)
                {
                    this._collectieRepository = new GenericRepository<Collectie>(_context);
                }
                return _collectieRepository;
            }
        }

        public IGenericRepository<Order> OrderRepository
        {
            get
            {
                if (this._orderRepository == null)
                {
                    this._orderRepository = new GenericRepository<Order>(_context);
                }
                return _orderRepository;
            }
        }
        public IGenericRepository<OrderProduct> OrderProductRepository
        {
            get
            {
                if (this._orderProductRepository == null)
                {
                    this._orderProductRepository = new GenericRepository<OrderProduct>(_context);
                }
                return _orderProductRepository;
            }
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
