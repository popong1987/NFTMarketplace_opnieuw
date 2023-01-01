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
    public class CollectieController : Controller
    {
        private readonly IUnitOfWork _uow;

        public CollectieController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ActionResult<IEnumerable<Collectie>>> Index()
        {
            CollectieListViewModel vm = new CollectieListViewModel()
            {
                Collecties = await _uow.CollectieRepository.GetAll().ToListAsync()
            };
            return View(vm);
        }

        public async Task<ActionResult<IEnumerable<Collectie>>> Details(int id)
        {
            var collectie = await _uow.CollectieRepository.GetById(id);
            /*List<Product> producten = await _uow.ProductRepository.GetAll()
                .Where(p => p.CollectieId == id)
                .ToListAsync();*/

            List<Product> producten = _uow.SpecificProductRepository.GetProductsForSpecificCollection(collectie);
 
            if (collectie != null)
            {
                CollectieDetailsViewModel vm = new CollectieDetailsViewModel()
                {
                    Naam = collectie.Naam,
                    AanmaakDatum = collectie.AanmaakDatum,
                    CreatorFee = collectie.CreatorFee,
                    Beschrijving = collectie.Beschrijving,
                    Afbeelding = collectie.Afbeelding,
                    Producten = producten
                };
                return View(vm);
            }
            else
            {
                CollectieListViewModel v = new CollectieListViewModel()
                {
                    Collecties = await _uow.CollectieRepository.GetAll().ToListAsync()
                };
                return View("Index", v);
            }
        }

    }
}
