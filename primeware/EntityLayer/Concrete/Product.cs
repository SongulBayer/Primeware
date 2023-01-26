using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string ProductDetails { get; set; }
        public string ProductDetails2 { get; set; }
        public string ProductImage { get; set; }
  
    }



}
