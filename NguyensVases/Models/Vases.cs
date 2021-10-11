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
        [StringLength(60, MinimumLength = 3)]   //The minimum / maximum length of characters the user can type in 
        [Required]
        public string Name { get; set; }        // the item name of the vase
        public string Material { get; set; }    // what the vase is made out of
        [Required]
        public string Color { get; set; }       // the color of the vase
        [Required]
        public string Weight { get; set; }      // describe the weight of the vase
        [Required]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]  // used to correctly map the price to currency in the database
        public decimal Price { get; set; }      // determine the price of the vase listed
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]  //the regular expression for the Rating??
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }      // determine the rating of the item
    }
}
