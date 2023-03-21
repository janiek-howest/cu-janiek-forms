using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FormViewModelExample.Web.ViewModels
{
    public class HomeContactViewModel
    {
        [Display(Name = "Naam:")]
        public string Name { get; set; }


        public string Department { get; set; }

        [Display(Name = "Uw Vraag:")]
        [MaxLength(255)]
        public string Question { get; set; }

        public List<SelectListItem> Departments { get; set; }

        public HomeContactViewModel()
        {
            Departments = new List<SelectListItem>();
        }
    }

}
