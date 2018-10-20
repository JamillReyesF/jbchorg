using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jbchorg.Models;
using System.Net.Mail;

namespace jbchorg.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Institucion()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Asociado()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Servicio()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Proyecto()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Contacto()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
            [HttpPost]
        public IActionResult Contacto(Mensaje m)
        {
            if (ModelState.IsValid) {
                // Guardar el mensaje en BD
                return RedirectToAction("Confirmacion");
            }
            
            return View(m);
        }
        public IActionResult Confirmacion()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
