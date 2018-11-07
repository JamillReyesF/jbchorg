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

   public class ProyectoController : Controller
    {
        private readonly JbchorgDBContext context;
        public ProyectoController(JbchorgDBContext c){
            context = c;
        }
        public IActionResult Proyecto()
        {
            ViewData["Message"] = "Your project page.";
        
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Proyecto(Proyecto pro)
        {
            if(ModelState.IsValid){
                context.Add(pro);    
                context.SaveChanges();
               return RedirectToAction("PConfirmacion");
            }
             return View(pro);
        }
        public IActionResult AConfirmacion()
        {
            ViewData["Message"] = "Your project page.";
        
            return View();
        }

        public async Task<IActionResult> Proyectos (string fNom)
        {
             var Proyectos = from m in context.Proyecto
             select m;
             if(!String.IsNullOrEmpty(fNom))
             {
                 Proyectos = Proyectos.Where(s => s.Nombre.Contains(fNom)); 
             }
             return View(await Proyectos.ToListAsync());
               
        }
        
       
    }
}

    