using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Supplier
    {
        [Key]
        [DisplayName("Supplier ID")]
        [Required(ErrorMessage = "Supplier ID is required")]
        public int ID { get; set; }

        [DisplayName("Supplier Name")]
        public string name { get; set; }

        [DisplayName("Supplier Location")]
        public string location { get; set; }

        public List<Product> products { get; set; }
    }
}
