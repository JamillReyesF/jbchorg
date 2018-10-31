using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jbchorg.Models;
using Microsoft.EntityFrameworkCore;

namespace jbchorg.Controllers
{

   public class AsociadoController : Controller
    {
        private readonly JbchorgDBContext context;
        public AsociadoController(JbchorgDBContext c){
            context = c;
        }
        public IActionResult Asociados(string buscar){
            var Asociados = context.Asociados.Include(e => e.TAsociado).AsQueryable();
            if(!string.IsNullOrEmpty(buscar))
            {
                Asociados = Asociados.Where(e => e.Nombre.Contains(buscar) || e.APaterno.Contains(buscar) || e.TAsociado.Nombre.Contains(buscar)); 
            }
            ViewBag.buscar = buscar;
            return View(Asociados.OrderBy(e => e.APaterno).ToList());
        }

    }
      
       
}
    /* 
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
  

    */
    