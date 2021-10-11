using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NguyensVases.Models

{
    public class VasesMaterialViewModel     //this adds a method to include a search box along with a filter to find a certain vases and material.
    {
        public List<Vases> Vases { get; set; }
        public SelectList Material { get; set; }
        public string VasesMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
