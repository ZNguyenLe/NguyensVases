using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NguyensVases.Models
{
    public class Vases
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Weight { get; set; }
        public decimal Price { get; set; }
    }
}
