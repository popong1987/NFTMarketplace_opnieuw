using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using NFTMarketplace_webapplicaties_opnieuw.Viewmodels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _uow;

        public HomeController(IUnitOfWork uow)
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

            if (collectie != null)
            {
                CollectieDetailsViewModel vm = new CollectieDetailsViewModel()
                {
                    Naam = collectie.Naam,
                    AanmaakDatum = collectie.AanmaakDatum,
                    CreatorFee = collectie.CreatorFee,
                    Beschrijving = collectie.Beschrijving,
                    Afbeelding = collectie.Afbeelding

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
