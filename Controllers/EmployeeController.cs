using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BookStore.Controllers
{
    public class EmployeeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // // 
        // // GET: /Employee/

        // public string Index()
        // {
        //     return "This is my default action...";
        // }

        // // 
        // // GET: /Employee/Welcome/ 

        // public string Welcome()
        // {
        //     return "This is the Welcome action method...";
        // }
    }
}