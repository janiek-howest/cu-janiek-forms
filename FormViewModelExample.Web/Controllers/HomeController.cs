using FormViewModelExample.Web.Models;
using FormViewModelExample.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace FormViewModelExample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            HomeContactViewModel model = new HomeContactViewModel();
            model.Departments.Add(new SelectListItem { Text = "Verkoop", Value = "sales" });
            model.Departments.Add(new SelectListItem { Text = "Technieker", Value = "technician", Selected = true });
            model.Departments.Add(new SelectListItem { Text = "Directie", Value = "ceo" });
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(HomeContactViewModel model)
        {
            model.Departments.Add(new SelectListItem { Text = "Verkoop", Value = "sales" });
            model.Departments.Add(new SelectListItem { Text = "Technieker", Value = "technician" });
            model.Departments.Add(new SelectListItem { Text = "Directie", Value = "ceo" });
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}