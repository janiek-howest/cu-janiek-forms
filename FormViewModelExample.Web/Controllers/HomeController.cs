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


            model.Terms = new List<TermCheckbox>
            {
                new TermCheckbox { Name  ="terms", Description = "Ik ga akkoord met de algemene voorwaarden"},
                new TermCheckbox { Name  ="privacy-policy", Description = "Ik heb de privacy policy gelezen."},
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(HomeContactViewModel model)
        {
            if(model.Department == "technician")
            {
                ModelState.AddModelError("Department", "We hebben geen techniekers meer ter beschikking");
            }
            if(ModelState.IsValid)
            {
                return RedirectToAction("ContactFormSubmitted");
            }
            model.Departments.Add(new SelectListItem { Text = "Verkoop", Value = "sales" });
            model.Departments.Add(new SelectListItem { Text = "Technieker", Value = "technician" });
            model.Departments.Add(new SelectListItem { Text = "Directie", Value = "ceo" });
            return View(model);
        }

        public IActionResult ContactFormSubmitted()
        {
            return Content("Je hebt succesvol het formulier ingevuld.");
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