using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Order
    {
        [Key]
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID is required")]
        public int ID { get; set; }

        [DisplayName("Quantity")]
        public int quantity { get; set; }

        [DisplayName("Total Price")]
        public decimal totalPrice { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Order Price")]
        public DateTime orderDate { get; set; }

        public decimal discount { get; set; }
        
        [DisplayName("Arrival Time")]
        public DateTime deliveryTime { get; set; }

        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "Customer ID is required")]
        [ForeignKey("customer")]
        public int cID { get; set; }

        public Customer customer { get; set; }


        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Product ID is required")]
        [ForeignKey("product")]
        public int productID { get; set; }

        public Product product { get; set; }


        public Payment payment { get; set; }
    }
}