using FormViewModelExample.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormViewModelExample.Web.Controllers
{
    public class EstaController : Controller
    {
        public IActionResult Apply()
        {
            EstaApplyViewModel model = new EstaApplyViewModel();
            model.ArrivalDate = DateTime.Now;
            model.Countries = GetCountries();

            return View(model);
        }

        [HttpPost]
        public IActionResult Process(EstaApplyViewModel model)
        {
            if(model.ArrivalDate < DateTime.Today)
            {
                ModelState.AddModelError("ArrivalDate", "U dient aan te komen vandaag of in de toekomst.");
            }
            if(ModelState.IsValid)
            {
                return Content("Thank you");
            }
            model.Countries = GetCountries();
            return View("Apply", model);
        }

        private List<SelectListItem> GetCountries()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = "Nederland", Value = "NL"},
                new SelectListItem { Text = "België", Value = "BE"},
            };
        }
    }
}
