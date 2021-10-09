using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyensVases.Models
{
    public class Vases
    {
        public int Id { get; set; }             // the id of the corresponding item
        public string Name { get; set; }        // the item name of the vase
        public string Material { get; set; }    // what the vase is made out of
        public string Color { get; set; }       // the color of the vase
        public string Weight { get; set; }      // describe the weight of the vase
        [Column(TypeName = "decimal(18, 2)")]   // used to correctly map the price to currency in the database
        public decimal Price { get; set; }      // determine the price of the vase listed
    }
}
