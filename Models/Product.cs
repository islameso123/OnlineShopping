using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Product
    {
        [Key]
        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Product ID is required")]
        public int ID { get; set; }

        [DisplayName("Product Name")]
        public string name { get; set; }

        [DisplayName("Stock")]
        public int stock { get; set; }

        [DisplayName("Category ID")]
        [Required(ErrorMessage = "Customer ID is required")]
        [ForeignKey("category")]
        public int catID { get; set; }

        public Category category { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal price { get; set; }

        [DisplayName("Supplier ID")]
        [Required(ErrorMessage = "Supplier ID is required")]
        [ForeignKey("supplier")]
        public int siD { get; set; }

        public Supplier supplier { get; set; }
    }
}
