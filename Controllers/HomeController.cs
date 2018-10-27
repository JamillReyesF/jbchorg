using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jbchorg.Models;
using System.Net.Mail;
//using System.Net.Mail.SmtpException;

namespace jbchorg.Controllers
{

//me sale que el net la version es antiga 
// en  mi carpeta particualar que trabajo si corre y se muestra el formulario de contacto
 
   
 
    public class HomeController : Controller
    {

        private readonly JbchorgDBContext context;


        public HomeController(JbchorgDBContext c){
            context = c;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Institucion()
        {
            ViewData["Message"] = "Your institution page.";

            return View();
        }

        public IActionResult Asociado()
        {
            ViewData["Message"] = "Your asociated page.";

            return View();
        }
        public IActionResult Activos()
        {
            ViewData["Message"] = "Your assets page.";

            return View();
        }
        public IActionResult Donacion()
        {
            ViewData["Message"] = "Your donation page.";

            return View();
        }
        public IActionResult Servicio()
        {
            ViewData["Message"] = "Your service page.";

            return View();
        }
        public IActionResult Proyecto()
        {
            ViewData["Message"] = "Your project page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        //no lo reconoce
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
