using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkAndTravelAgency.Infrastructure.Data
{
    public class Employer
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int JobTypeId { get; set; }

        [ForeignKey(nameof(JobTypeId))]
        public JobType JobType { get; set; } = null!;

    }
}
