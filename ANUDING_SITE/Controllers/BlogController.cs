﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ANUDING_SITE.Controllers
{
    public class BlogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Articles()
        {
            Models.BlogContext context = HttpContext.RequestServices.GetService(typeof(ANUDING_SITE.Models.BlogContext)) as Models.BlogContext;
            return View(context.GetAllBlog());
            //return View();
        }
    }
}
