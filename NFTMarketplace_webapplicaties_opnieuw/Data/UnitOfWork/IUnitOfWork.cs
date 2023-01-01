using NFTMarketplace_webapplicaties_opnieuw.Data.Repositories;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Product> ProductRepository { get; }
        IGenericRepository<ProductProperty> ProductPropertyRepository { get; }
        IGenericRepository<Collectie> CollectieRepository { get; }
        IGenericRepository<Order> OrderRepository { get; }
        IGenericRepository<OrderProduct> OrderProductRepository { get; }
        IOrderRepository SpecificOrderRepository { get; }
        IProductPropertiesRepository SpecificProductPropertiesRepository { get; }
        IProductRepository SpecificProductRepository { get; }
        Task Save();
    }
}
