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

   public class AsociadoController : Controller
    {
        private readonly JbchorgDBContext context;
        public AsociadoController(JbchorgDBContext c){
            context = c;
        }
        public IActionResult Asociado()
        {
            ViewData["Message"] = "Your contact page.";
        
            return View();
        }
        [HttpPost]
        public IActionResult Asociado(Asociado aso)
        {
            if(ModelState.IsValid){
                context.Add(aso);    
                context.SaveChanges();
               return RedirectToAction("AConfirmacion");
            }
             return View(aso);
        }
         public IActionResult AConfirmacion()
        {
            ViewData["Message"] = "Your contact page.";
        
            return View();
        }
  
    }
}