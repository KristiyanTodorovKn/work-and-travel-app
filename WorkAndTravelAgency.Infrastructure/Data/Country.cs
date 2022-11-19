using System.ComponentModel.DataAnnotations;

namespace WorkAndTravelAgency.Infrastructure.Data
{
    public class Country
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string Flag { get; set; } = null!;

    }
}
