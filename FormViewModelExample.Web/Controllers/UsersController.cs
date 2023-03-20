using FormViewModelExample.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FormViewModelExample.Web.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            var model = new UsersRegisterViewModel();
            return View(model);
        }


        [HttpPost]
        public IActionResult Register(UsersRegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                if (model.Password != model.PasswordConfirm)
                {
                    ViewData["message"] = "Wachtwoorden komen niet overeen.";
                    return View(model);
                }
                return RedirectToAction("RegistrationSuccess");
            }
            ViewData["message"] = "Er zijn fouten in het model.";
            return View(model);
        }

        public IActionResult RegistrationSuccess()
        {
            return Content("Bedankt !! U kan nu inloggen... ");
        }
    }
}
