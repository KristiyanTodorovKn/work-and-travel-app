using System.ComponentModel.DataAnnotations;

namespace WorkAndTravelAgency.Core.Models.Agent
{
    public class BecomeAgentModel
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(15, MinimumLength = 7)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;

    }
}
