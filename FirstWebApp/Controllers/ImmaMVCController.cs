using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    public class ImmaMVCController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public string Route() //static???
        {
            return "dkld";
        }

        public string Route(string naam, int leeftijd)
        {
            return $"hallo {naam} die {leeftijd} jaar oud is";
        }
    }
}
