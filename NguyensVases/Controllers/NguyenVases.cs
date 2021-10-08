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
        public IActionResult Index()
        {
            return View();
        }
<<<<<<< HEAD
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
=======
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
>>>>>>> 4fd97062077388b3584f1c484986ab71d8b88633
        }
    }
}
