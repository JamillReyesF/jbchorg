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
        public IActionResult Asociado()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        
    }
}