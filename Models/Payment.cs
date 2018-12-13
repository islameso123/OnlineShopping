using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Payment
    {
        /*
        [Key]
        [DisplayName("Payment ID")]
        [Required(ErrorMessage = "Payment ID is required")]
        public int ID { get; set; }
        */
        
        [Key]
        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "Customer ID is required")]
        public int cID { get; set; }
        
        [ForeignKey("cID")]
        public Customer customer { get; set; }
        
        
        [Key]
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID is required")]
        public int oID { get; set; } // fk
        
        [ForeignKey("oID")]
        public Order order { get; set; }
        

        [DataType(DataType.Date)]
        public DateTime paymantDate { get; set; }
    }
}
