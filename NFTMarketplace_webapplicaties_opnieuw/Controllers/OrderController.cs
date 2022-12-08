using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using NFTMarketplace_webapplicaties_opnieuw.Viewmodels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _uow;

        public OrderController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        /*public ViewResult Index()
        {
            return View();
        }*/

        public async Task<ActionResult> Index(int productId)
        {
            var selectedProduct = await _uow.ProductRepository.GetById(productId);
            OrderProduct Item = new OrderProduct();
            if (selectedProduct != null)
            {
                Item.Product = selectedProduct;
                Item.OrderId = 1;
                Item.Aantal = 1;
               
                _uow.OrderProductRepository.Create(Item);
            }

            Order order= await _uow.OrderRepository.GetById(Item.OrderId);
            if(order != null)
            {
                OrderOverviewViewModel vm = new OrderOverviewViewModel()
                {
                    Order = order,

                };
                return View(vm);
            }
            return View(null);
        }
    }
}
