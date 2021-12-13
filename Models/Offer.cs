using System.ComponentModel.DataAnnotations;

namespace BOK.Models
{
    public class Offer
    {
        public int Id { get; set; }

        [Display(Name = "Offer name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Speed")]
        [Range(10, 1000)]
        [Required]
        public int Speed { get; set; }

        [Display(Name = "Optical fibre")]
        [Required]
        public bool OpticalFibre { get; set; }

        [Display(Name = "Monthly cost")]
        [Required]
        public int MonthlyCost { get; set; }

        [Range(3, 48)]
        [Display(Name = "Commitment period")]
        [Required]
        public int CommitmentPeriod { get; set; }
    }
}