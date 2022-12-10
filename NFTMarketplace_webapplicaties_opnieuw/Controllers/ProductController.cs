using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NFTMarketplace_webapplicaties_opnieuw.Areas.Identity.Data;
using NFTMarketplace_webapplicaties_opnieuw.Data;
using NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using NFTMarketplace_webapplicaties_opnieuw.Viewmodels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _uow;
        private readonly NFTMarketplaceContext _context;
        private readonly UserManager<Gebruiker> _userManager;

        public ProductController(IUnitOfWork uow, NFTMarketplaceContext context, UserManager<Gebruiker> userManager)
        {
            _uow = uow;
            _context = context;
            _userManager = userManager;
        }

        public async Task<ActionResult<IEnumerable<Product>>> Index()
        {
            ProductListViewModel vm = new ProductListViewModel()
            {
                Producten = await _uow.ProductRepository.GetAll().ToListAsync()
            };
            return View(vm);
        }

        public async Task<ActionResult<IEnumerable<Product>>> Details(int id)
        {
            var product = await _uow.ProductRepository.GetById(id);

            List<ProductProperty> productProperties = await _uow.ProductPropertyRepository.GetAll()
                .Include(p => p.Property)
                .Where(pp => pp.ProductId == id)
                .ToListAsync();


            if (product != null)
            {
                ProductDetailsViewModel vm = new ProductDetailsViewModel()
                {
                    Naam = product.Naam,
                    Prijs = product.Prijs,
                    Afbeelding = product.Afbeelding,
                    Beschrijving = product.Beschrijving,
                    AanmaakDatum = product.AanmaakDatum,
                    AantalBeschikbaar = product.AantalBeschikbaar,
                    CollectieId = product.CollectieId,
                    ProductId = product.ProductId,
                    ProductProperties = productProperties,

                };
                return View(vm);
            }
            else
            {
                ProductListViewModel v = new ProductListViewModel()
                {
                    Producten = await _uow.ProductRepository.GetAll().ToListAsync()
                };
                return View("Index", v);
            }
        }

        [HttpGet]
        public async Task<ActionResult> CreateOrderProduct(int id)
        {

           

            Gebruiker gebruiker = await _userManager.GetUserAsync(HttpContext.User);
            Order order = await _context.Orders.Where(o => o.GebruikerId == gebruiker.Id && o.IsWinkelmandje == true).FirstOrDefaultAsync();
            Product product = await _uow.ProductRepository.GetById(id);

            string gebruikerId = gebruiker.Id;

            if (order == null)
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


    }
}
