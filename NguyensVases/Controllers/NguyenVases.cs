using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;


namespace NguyensVases.Controllers
{
    public class NguyenVases : Controller
    {
        public IActionResult Index()        // this connects to the Index.cshtml and will return a page if the index is typed in the search bar in the browser.
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1) //a search method to the welcome page so that it will display the name and the about of numbers.
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
