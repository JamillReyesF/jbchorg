using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jbchorg.Models;


namespace jbchorg.Controllers
{

//me sale que el net la version es antiga 
// en  mi carpeta particualar que trabajo si corre y se muestra el formulario de contacto
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
                //falta el envio de datos al correo 
                //ya no sale error en el using system.Net.Mail
                // estoy avanzando el diseño y el envio al correo que dando gracias que ya nos contactaremos 
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

        //no lo reconoce
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
