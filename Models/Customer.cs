using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Customer
    {
        [Key]
        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "ID is required")]
        public int ID { get; set; }

        [DisplayName("Customer Name")]
        public string name { get; set; }

        [DisplayName("Birth Date")]
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }

        public bool gender { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public List<Order> _orders { get; set; }
    }
}
