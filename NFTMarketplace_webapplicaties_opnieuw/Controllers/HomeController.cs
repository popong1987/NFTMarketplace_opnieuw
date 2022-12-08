using Microsoft.AspNetCore.Mvc;

namespace NFTMarketplace_webapplicaties_opnieuw.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
