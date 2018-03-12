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

        public IActionResult Route() //static???
        {
            ViewData["slechteRoute"] = "dkd";
            return View(); //ViewData: dictionnary om data door te geven aan ...; ViewBag?
            
        }

        public IActionResult Route(string naam = "iemand", int leeftijd = 00)
        {
            ViewData["betereRoute"] = $"hallo {naam} die {leeftijd} jaar oud is";
            return View();
        }
    }
}