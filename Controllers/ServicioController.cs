using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jbchorg.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace jbchorg.Controllers
{
    public class ServicioController : Controller
    {
        private readonly JbchorgDBContext context;
        public ServicioController(JbchorgDBContext c){
            context = c;
        }
        public IActionResult Servicio()
        {
            ViewData["Message"] = "Your contact page.";
        
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]  
         public IActionResult Servicio(Servicio serv)
        {
            if(ModelState.IsValid){
                context.Add(serv);    
                context.SaveChanges();
               return RedirectToAction("AConfirmacion");
            }
             return View(serv);
        }
        public IActionResult AConfirmacion()
        {
            ViewData["Message"] = "Your contact page.";
        
            return View();
        }
       public async Task<IActionResult> Servicio (string fNom)
        {
             var servicio = from m in context.Asociado
             select m;
             if(!String.IsNullOrEmpty(fNom))
             {
                 servicio = servicio.Where(s => s.Nombre.Contains(fNom)); 
             }
             return View(await servicio.ToListAsync());      
        }




    }
}