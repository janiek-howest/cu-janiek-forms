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
            model.Countries = new List<SelectListItem>
            {
                new SelectListItem { Text = "Nederland", Value = "NL"},
                new SelectListItem { Text = "België", Value = "BE"},
            };

            return View(model);
        }
    }
}
