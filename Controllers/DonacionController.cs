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
    public class DonacionController : Controller
    {
        private readonly JbchorgDBContext context;
        public DonacionController(JbchorgDBContext c){
            context = c;
        }
        public IActionResult Donacion()
        {
            ViewData["Message"] = "Your contact page.";
        
            return View();
        }
        [HttpPost]
        public IActionResult Donacion(Donacion don)
        {
            if(ModelState.IsValid){
               
               return RedirectToAction("DConfirmacion");
            }
             return View(don);
        }
         public IActionResult DConfirmacion()
        {
            ViewData["Message"] = "Your contact page.";
        
            return View();
        }
    }
}