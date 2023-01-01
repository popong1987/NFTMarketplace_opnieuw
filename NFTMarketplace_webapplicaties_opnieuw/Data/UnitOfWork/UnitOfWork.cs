using NFTMarketplace_webapplicaties_opnieuw.Data.Repositories;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly NFTMarketplaceContext _context;
        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<ProductProperty> _productPropertyRepository;
        private IGenericRepository<Collectie> _collectieRepository;
        private IGenericRepository<Order> _orderRepository;
        private IGenericRepository<OrderProduct> _orderProductRepository;
        private IOrderRepository _specificOrderRepository;
        private IProductPropertiesRepository _specificProductPropertiesRepository;
        private IProductRepository _specificProductRepository;

        public UnitOfWork(NFTMarketplaceContext context)
        {
            _context = context;

        }

        public IOrderRepository SpecificOrderRepository
        {
            get
            {
                if (this._specificOrderRepository == null)
                {
                    this._specificOrderRepository = new OrderRepository(_context);
                }
                return _specificOrderRepository;
            }
        }

        public IProductPropertiesRepository SpecificProductPropertiesRepository
        {
            get
            {
                if (this._specificProductPropertiesRepository == null)
                {
                    this._specificProductPropertiesRepository = new ProductPropertiesRepository(_context);
                }
                return _specificProductPropertiesRepository;
            }
        }

        public IProductRepository SpecificProductRepository
        {
            get
            {
                if (this._specificProductRepository == null)
                {
                    this._specificProductRepository = new ProductRepository(_context);
                }
                return _specificProductRepository;
            }
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
