using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public ProductController(IUnitOfWork uow)
        {
            _uow = uow;
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

        public async Task<ActionResult<IEnumerable<Product>>> Create()
        {
            CreateProductViewModel vm = new CreateProductViewModel()
            {
                Collecties = await _uow.CollectieRepository.GetAll().ToListAsync()
            };
            return View(vm);
        }
    }
}
