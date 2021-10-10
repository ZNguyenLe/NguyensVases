using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NguyensVases.Models

{
    public class VasesMaterialViewModel
    {
        public List<Vases> Vases { get; set; }
        public SelectList Material { get; set; }
        public string VasesMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
