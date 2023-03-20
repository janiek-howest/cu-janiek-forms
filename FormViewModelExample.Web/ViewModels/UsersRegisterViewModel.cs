using System.ComponentModel.DataAnnotations;

namespace FormViewModelExample.Web.ViewModels
{
    public class UsersRegisterViewModel
    {
        [Display( Name  = "Voornaam")]
        [Required]
        public string FirstName { get; set; }

        [Display( Name = "Achternaam")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Paswoord")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Herhaal paswoord")]
        [DataType(DataType.Password)]
        [Required]
        public string PasswordConfirm { get; set; }
    }
}
