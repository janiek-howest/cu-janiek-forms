using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FormViewModelExample.Web.ViewModels
{
    public class EstaApplyViewModel
    {

        [Required]
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mailadres")]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(10)]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string Country { get; set; }

        public List<SelectListItem> Countries { get; set; }

        public bool ReceiveByMail { get; set; }
    }
}
