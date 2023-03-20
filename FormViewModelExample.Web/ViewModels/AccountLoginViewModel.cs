using System.ComponentModel.DataAnnotations;

namespace FormViewModelExample.Web.ViewModels
{
    public class AccountLoginViewModel
    {

        [Display(Name = "E-mail")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Paswoordtje")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
