using System.ComponentModel.DataAnnotations;

namespace task14022022.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required, Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Description")]
        public string ProductDescription { get; set; }
        [Display(Name = "Image")]
        public string ProductImage { get; set; }
        [Display(Name = "Category")]
        public string ProductCategory { get; set; }
        [Range(0,20,ErrorMessage ="Quantity cannot more than 20, and cannot be negative"), Display(Name = "Available Stock")]
        public int ProductQuantity { get; set; }
        [Range(0, 9999, ErrorMessage = "Price cannot be negative"), Display(Name = "Price")]
        public double ProductPrice { get; set; }
    }
}
