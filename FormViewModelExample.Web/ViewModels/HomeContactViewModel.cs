using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FormViewModelExample.Web.ViewModels
{
    public class HomeContactViewModel
    {
        [Display(Name = "Naam:")]
        [Required( ErrorMessage = "Vul a.u.b. uw naam in, anders kunnen we jou niet terug contacteren.")]
        public string Name { get; set; }

        
        public string Department { get; set; }

        [Display(Name = "Uw Vraag:")]
        [MaxLength(25)]
        [Required]
        public string Question { get; set; }



        public List<SelectListItem> Departments { get; set; }

        public HomeContactViewModel()
        {
            Departments = new List<SelectListItem>();
        }
        public List<TermCheckbox> Terms { get; set; }
    }

    public class TermCheckbox
    {
        public string Description { get; set; }

        public string Name { get; set; }

        public bool IsSelected { get; set; } = false;
    }

}
