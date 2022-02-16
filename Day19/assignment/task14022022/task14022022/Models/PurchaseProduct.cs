using System.ComponentModel.DataAnnotations;

namespace task14022022.Models
{
    public class PurchaseProduct
    {
        public Product Product { get; set; }
        [Display(Name = "Quantity Purchase")]
        public int PurchaseQty { get; set; }
        [Display(Name = "Total Amount")]
        public double TotalPrice { get; set; }
    }
}
