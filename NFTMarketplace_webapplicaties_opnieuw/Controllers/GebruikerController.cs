using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NFTMarketplace_webapplicaties_opnieuw.Areas.Identity.Data;
using NFTMarketplace_webapplicaties_opnieuw.Viewmodels;
using System.Linq;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Controllers
{
    public class GebruikerController : Controller
    {
        private UserManager<Gebruiker> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public GebruikerController(UserManager<Gebruiker> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            GebruikerListViewModel vm = new GebruikerListViewModel()
            {
                Gebruikers = _userManager.Users.ToList()
            };
            return View(vm);
        }

        public IActionResult Details(string id)
        {
            Gebruiker gebruiker = _userManager.Users.Where(g => g.Id == id).FirstOrDefault();

            if(gebruiker != null)
            {
                GebruikerDetailsViewModel vm = new GebruikerDetailsViewModel()
                {
                    Id = gebruiker.Id,
                    Naam = gebruiker.Naam,
                    UserName = gebruiker.UserName,
                    GeboorteDatum = gebruiker.Geboortedatum
                };
                return View(vm);
            }
            else
            {
                GebruikerListViewModel vm = new GebruikerListViewModel()
                {
                    Gebruikers = _userManager.Users.ToList()
                };
                return View("Index", vm);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateGebruikerViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Gebruiker gebruiker = new Gebruiker
                {
                    Naam = vm.Naam,
                    Geboortedatum = vm.GeboorteDatum,
                    UserName = vm.UserName,
                    Email = vm.Email,
                };

                IdentityResult result = await _userManager.CreateAsync(gebruiker, vm.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(vm);
        }

        [HttpPost]

        public async Task<IActionResult> Delete(string id)
        {
            Gebruiker gebruiker = await _userManager.FindByIdAsync(id);
            if(gebruiker != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(gebruiker);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View("Index", _userManager.Users.ToList());
        }

        public IActionResult GrantPermissions()
        {
            GrantPermissionsViewModel vm = new GrantPermissionsViewModel()
            {
                Gebruikers = new SelectList(_userManager.Users.ToList(), "Id", "UserName"),
                Rollen = new SelectList(_roleManager.Roles.ToList(), "Id", "Name")
            };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> GrantPermissions(GrantPermissionsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Gebruiker user = await _userManager.FindByIdAsync(viewModel.GebruikerId);
                IdentityRole role = await _roleManager.FindByIdAsync(viewModel.RolId);

                if (!await _userManager.IsInRoleAsync(user, role.Name))
                {
                    if (user != null && role != null)
                    {
                        IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);

                        if (result.Succeeded)
                            return RedirectToAction("Index");
                        else
                        {
                            foreach (IdentityError error in result.Errors)
                                ModelState.AddModelError("", error.Description);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "User or role Not found");
                    }
                }
                else
                {
                    return RedirectToAction("index");
                }
            }
            return View(viewModel);
        }
    }
}
