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
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Herhaal paswoord")]
        [DataType(DataType.Password)]
        [Required]
        [Compare(nameof(Password), ErrorMessage ="Paswoorden moeten gelijk zijn")]
        public string PasswordConfirm { get; set; }
    }
}
