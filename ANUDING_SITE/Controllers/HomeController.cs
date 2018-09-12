using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ANUDING_SITE.Models;

namespace ANUDING_SITE.Controllers
{
    //[Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Models.BlogContext context = HttpContext.RequestServices.GetService(typeof(ANUDING_SITE.Models.BlogContext)) as Models.BlogContext;
            return View(context.GetAllBlog());
            //return View();
        }
        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{

        //    return new string[] { "value1", "value2" };

        //}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
