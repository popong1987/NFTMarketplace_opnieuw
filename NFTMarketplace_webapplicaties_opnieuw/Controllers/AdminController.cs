using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NFTMarketplace_webapplicaties_opnieuw.Data;
using NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using NFTMarketplace_webapplicaties_opnieuw.Viewmodels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _uow;
        private IWebHostEnvironment _environment;

        public AdminController(IUnitOfWork uow, IWebHostEnvironment enviroment)
        {
           _uow = uow;
            _environment = enviroment;
        }

        public async Task<ActionResult<IEnumerable<Product>>> Index()
        {
            ProductListViewModel vm = new ProductListViewModel()
            {
                Producten = await _uow.ProductRepository.GetAll().ToListAsync()
            };
            return View(vm);
        }

        public async Task<ActionResult<IEnumerable<Product>>> Producten()
        {
            ProductListViewModel vm = new ProductListViewModel()
            {
                Producten = await _uow.ProductRepository.GetAll().ToListAsync()
            };
            return View(vm);
        }


        public async Task<ActionResult> CreateProduct()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateProduct(CreateProductViewModel vm)
        {

            if (ModelState.IsValid)
            {
                string sUserName = User.Identity.Name;

                string path = Path.Combine(this._environment.WebRootPath, "UploadFiles", sUserName);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                foreach(IFormFile postedFile in vm.PostedFiles)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);

                    using(var stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        stream.Position = 0;
                        await postedFile.CopyToAsync(stream);
                    }
                }

                _uow.ProductRepository.Create(new Product()
                {
                    Naam = vm.Naam,
                    Prijs = vm.Prijs,
                    Afbeelding = path,
                    Beschrijving = vm.Beschrijving,
                    AanmaakDatum = vm.AanmaakDatum,
                    AantalBeschikbaar = vm.AantalBeschikbaar,
                    CollectieId = vm.CollectieId,


                });
                await _uow.Save();
                return RedirectToAction(nameof(Producten));
            }
            return View(vm);
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            Product product = await _uow.ProductRepository.GetById(id);
            if(product != null)
            {
                DeleteProductViewModel vm = new DeleteProductViewModel()
                {
                    ProductId = id,
                    Naam = product.Naam,
                    Prijs = product.Prijs,
                    Afbeelding = product.Afbeelding,
                    Beschrijving = product.Beschrijving,
                    AanmaakDatum = product.AanmaakDatum,
                    AantalBeschikbaar = product.AantalBeschikbaar,
                    CollectieId = product.CollectieId
                };

                return View(vm);
            }
            else
            {
                ProductListViewModel vm = new ProductListViewModel()
                {
                    Producten = await _uow.ProductRepository.GetAll().ToListAsync()
                };
                return RedirectToAction(nameof(Producten));
            }
        }

        [HttpPost, ActionName("DeleteProduct")]

        public async Task<IActionResult> DeleteProductConfirm(int id)
        {
            Product product = await _uow.ProductRepository.GetById(id);
            _uow.ProductRepository.Delete(product);
            await _uow.Save();
            return RedirectToAction(nameof(Producten));
        }

        [HttpGet]
        public async Task<IActionResult> EditProduct(int id)
        {
            Product product = await _uow.ProductRepository.GetById(id);

            if(product == null)
            {
                return NotFound();
            }

            EditProductViewModel vm = new EditProductViewModel()
            {
                ProductId = product.ProductId,
                Naam = product.Naam,
                Prijs = product.Prijs,
                Afbeelding = product.Afbeelding,
                Beschrijving = product.Beschrijving,
                AanmaakDatum = product.AanmaakDatum,
                AantalBeschikbaar = product.AantalBeschikbaar,
                CollectieId = product.CollectieId
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> EditProduct(int id, EditProductViewModel vm)
        {
            if(id != vm.ProductId)
            {
                return NotFound();
            }

            Product product = await _uow.ProductRepository.GetById(id);

            if (ModelState.IsValid)
            {
                try
                {
                    product.ProductId = vm.ProductId;
                    product.Naam = vm.Naam;
                    product.Prijs = vm.Prijs;
                    product.Afbeelding = vm.Afbeelding;
                    product.Beschrijving = vm.Beschrijving;
                    product.AantalBeschikbaar = vm.AantalBeschikbaar;
                    product.CollectieId = vm.CollectieId;

                    _uow.ProductRepository.Update(product);
                    await _uow.Save();
                }
                catch(DbUpdateConcurrencyException e)
                {
                    /*if(!_uow.ProductRepository.*/
                    throw;
                }
                return RedirectToAction(nameof(Producten));
            }
            return View(vm);
        }
    }
}
