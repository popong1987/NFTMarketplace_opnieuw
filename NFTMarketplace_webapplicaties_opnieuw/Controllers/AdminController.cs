using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NFTMarketplace_webapplicaties_opnieuw.Data;
using NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using NFTMarketplace_webapplicaties_opnieuw.Viewmodels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _uow;

        public AdminController(IUnitOfWork uow)
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


        public async Task<ActionResult<IEnumerable<Product>>> CreateProduct()
        {
            /*CreateProductViewModel vm = new CreateProductViewModel()
            {
                Collecties = await _uow.CollectieRepository.GetAll().ToListAsync()
            };*/
            return View();
        }



        [HttpPost]
        public async Task<ActionResult> CreateProduct(CreateProductViewModel vm)
        {


            if (ModelState.IsValid)
            {
                _uow.ProductRepository.Create(new Product()
                {
                    Naam = vm.Naam,
                    Prijs = vm.Prijs,
                    Afbeelding = vm.Afbeelding,
                    Beschrijving = vm.Beschrijving,
                    AanmaakDatum = vm.AanmaakDatum,
                    AantalBeschikbaar = vm.AantalBeschikbaar,
                    CollectieId = vm.CollectieId,


                });
                await _uow.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }


    }
}
