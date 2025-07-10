using System.ComponentModel.DataAnnotations;

namespace MVCMiniProject.Models
{
    public class AddressModel
    {
        [Required]
        [Display(Name = "House Number")]
        public string HouseNumber { get; set; }

        [Required]
        [Display(Name = "Post Code")]
        [StringLength(8, MinimumLength = 5)]
        public string Postcode { get; set; }
    }
}
