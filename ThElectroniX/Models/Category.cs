using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThElectroniX.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }
    }
}
