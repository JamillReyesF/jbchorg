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
               return RedirectToAction("SConfirmacion");
            }
             return View(serv);
        }
        public IActionResult SConfirmacion()
        {
            ViewData["Message"] = "Your contact page.";
        
            return View();
        }
       public async Task<IActionResult> Servicios (string fNom)
        {
             var servi = from sv in context.Servicio
             select sv;
             if(!String.IsNullOrEmpty(fNom))
             {
                 servi = servi.Where(s => s.NombreServ.Contains(fNom) || s.tipo.Contains(fNom)); 
             }
             return View(await servi.ToListAsync());      
        }




    }
}