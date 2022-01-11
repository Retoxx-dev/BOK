using System.ComponentModel.DataAnnotations;

namespace BOK.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Offer name")] public int OfferId { get; set; }
        public virtual Offer Offer { get; set; }
    }
}