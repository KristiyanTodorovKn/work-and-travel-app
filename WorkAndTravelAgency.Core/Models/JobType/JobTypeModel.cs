using System.ComponentModel.DataAnnotations;
using WorkAndTravelAgency.Core.Models.Agent;

namespace WorkAndTravelAgency.Core.Models.JobType
{
    public class JobTypeModel
    {
        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; } = null!;

        [Required]
        [Display(Name = "Salary per week")]
        [Range(0.00, 2000.00, ErrorMessage = "Price per week must be a positive number and less than {2} leva")]
        public decimal Salary { get; set; }

        [Display(Name = "Agent")]
        public int AgentId { get; set; }

        public BecomeAgentModel Agent { get; set; } = null!;
    }
}
