using FormViewModelExample.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FormViewModelExample.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            var model = new AccountLoginViewModel();
            model.RememberMe = true;

            return View(model);
        }

        [HttpPost]
        public IActionResult Login(AccountLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Email != "jules@verne.com" || model.Password != "unsafe123")
                {
                    ModelState.AddModelError("", "Combinatie gebruikersnaam en wachtwoord komen niet overeen.");
                    return View(model);
                }

                return RedirectToAction("LoginSuccess");
            }

            return View(model);
        }

        public IActionResult AdminHomepage()
        {
            return Content("Je bent succesvol ingelogd");
        }

        public IActionResult LoginSuccess()
        {
            return Content("Je bent succesvol ingelogd");
        }
    }
}
