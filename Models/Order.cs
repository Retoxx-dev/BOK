using System.ComponentModel.DataAnnotations;

namespace BOK.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Client")] public int UserId { get; set; }
        public virtual User User { get; set; }
        [Display(Name = "Offer name")] public int OfferId { get; set; }
        public virtual Offer Offer { get; set; }
    }
}