using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using NFTMarketplace_webapplicaties_opnieuw.Areas.Identity.Data;
using NFTMarketplace_webapplicaties_opnieuw.Data;
using NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using NFTMarketplace_webapplicaties_opnieuw.Viewmodels;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NFTMarketplace_webapplicaties_opnieuw.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _uow;
        private readonly NFTMarketplaceContext _context;
        private readonly UserManager<Gebruiker> _userManager;

        public OrderController(IUnitOfWork uow, UserManager<Gebruiker> userManager, NFTMarketplaceContext context)
        {
            _uow = uow;
            _userManager = userManager;
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            Gebruiker gebruiker = await _userManager.GetUserAsync(HttpContext.User);
            Order order = await _context.Orders.Where(o => o.GebruikerId == gebruiker.Id && o.IsWinkelmandje == true).FirstOrDefaultAsync();
            if(order == null)
            {
                return RedirectToAction(nameof(EmptyCart));
            }
            List<OrderProduct> orderProducten = await _uow.OrderProductRepository.GetAll()
                .Include(op => op.Product)
                .Where(o => o.OrderId == order.OrderId)
                .ToListAsync();

            if(orderProducten != null)
            {
                OrderOverviewViewModel vm = new OrderOverviewViewModel()
                {
                    OrderId = order.OrderId,
                    OrderProducten = orderProducten
                };
                return View(vm);
            }
            
            return RedirectToAction(nameof(EmptyCart));
        }

        public async Task<ActionResult> EmptyCart()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateOrderProduct(ProductDetailsViewModel vm)
        {
           
            Gebruiker gebruiker = await _userManager.GetUserAsync(HttpContext.User);
            Order order = await _context.Orders.Where(o => o.GebruikerId == gebruiker.Id && o.IsWinkelmandje == true).FirstOrDefaultAsync();
            Product product = await _uow.ProductRepository.GetById(vm.ProductId);

            string gebruikerId = gebruiker.Id;

            if(order == null)
            {
                order = new Order()
                {

                    TotalePrijs = product.Prijs,
                    GebruikerId = gebruiker.Id,
                    IsWinkelmandje = true
                };
                _uow.OrderRepository.Create(order);
                await _uow.Save();
            }




            _uow.OrderProductRepository.Create(new OrderProduct()
            {
                Aantal = 1,
                Prijs = product.Prijs,
                ProductId = product.ProductId,
                OrderId = order.OrderId
            });
            await _uow.Save();
            return RedirectToAction(nameof(Index));

        }

        public async Task<ActionResult> Pay(OrderOverviewViewModel vm)
        {
            Order order = await _uow.OrderRepository.GetById(vm.OrderId);
            if (ModelState.IsValid)
            {
                try
                {
                    order.OrderId = vm.OrderId;
                    order.TotalePrijs = vm.TotalePrijs;
                    order.GebruikerId = vm.GebruikerId;
                    order.OrderProducten = vm.OrderProducten;
                    order.IsWinkelmandje = false;
                    _uow.OrderRepository.Update(order);
                    await _uow.Save();
                }
                catch(DbUpdateConcurrencyException e)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }
    }
}
