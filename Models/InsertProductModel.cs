using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3_LinqWindowsForm.Models
{
    public class InsertProductModel
    {
        [Required(ErrorMessage = "Field is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field is Required")]
        public string ProductNumber { get; set; }
        [Required(ErrorMessage = "Field is Required")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Field is Required"), Range(1, Int16.MaxValue)]
        public Int16 StockLevel { get; set; }
        [Required(ErrorMessage = "Field is Required"), Range(1, Int16.MaxValue)]
        public Int16 ReorderPoint { get; set; }
        [Required(ErrorMessage = "Field is Required")]
        public decimal LastPrice { get; set; }
        [Required(ErrorMessage = "Field is Required")]
        public string Size { get; set; }
    }
}
