using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category ID")]
        [Required(ErrorMessage = "Category ID is required")]
        public int ID { set; get; }

        [DisplayName("Category Name")]
        public string name { get; set; }

        public List<Product> products { get; set; }
    }
}
