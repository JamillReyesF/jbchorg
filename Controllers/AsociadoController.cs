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

   public class AsociadoController : Controller
    {
        private readonly JbchorgDBContext context;
        public AsociadoController(JbchorgDBContext c){
            context = c;
        }
        public IActionResult Asociado()
        {
            ViewData["Message"] = "Your contact page.";
            precargaDeDatos();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        public IActionResult Asociados(string buscar){
            var asociados = context.Asociados.Include(e=>e.TAsociado).AsQueryable();
            if(!string.IsNullOrEmpty(buscar)){
                asociados = asociados.Where(e=>e.Nombre.Contains(buscar) || 
                e.AMaterno.Contains(buscar)|| e.TAsociado.Nombre.Contains(buscar));
            }
            ViewBag.buscar=buscar;
            return View(asociados.OrderBy(e=>e.APaterno).ToList());
        }
        private void precargaDeDatos(){
            ViewBag.TAsociado = new SelectList(context.TAsociados,"Id","Nombre");
        }


        
       
    }
}

    