using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace B2BWebApp.Controllers
{
    public class GraniteController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}