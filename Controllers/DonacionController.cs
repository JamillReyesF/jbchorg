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
        private readonly JbchorgDBContext _context;

        public DonacionController(JbchorgDBContext c){
            this._context = c;
        }

        public IActionResult Donacion()
        {
            ViewData["Message"] = "Your donation page.";

            return View();
        }

        [HttpPost]
        public IActionResult Donacion(Donacion d)
        {
            if (ModelState.IsValid) {
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add("rosmery_molina@usmp.pe");
            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

        //Asunto
        mmsg.Subject = "Registro de nueva Donación";
        mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
        //Direccion de correo electronico que queremos que reciba una copia del mensaje
        //mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional


        //Cuerpo del Mensaje
        mmsg.Body = "Datos Personales :\n\tNombre : "+d.Nombre+"\n\tApellido Paterno: "+d.APaterno+
                    "\n\tApellido Materno : "+d.AMaterno+"\n\tCorreo : "+d.Correo+
                    "\n\tDNI : "+d.DNI+
                    "\n\tTelefono : "+d.Movil+
                    "\n\tBanco : "+d.Banco+
                    "\n\tTarjeta : "+d.Tarjeta+
                    "\n\tMonto : "+d.Monto;
        ;
        mmsg.BodyEncoding = System.Text.Encoding.UTF8;
        mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

        //Correo electronico desde la que enviamos el mensaje
        mmsg.From = new System.Net.Mail.MailAddress("jamillreyesf@gmail.com");

        /*-------------------------CLIENTE DE CORREO----------------------*/

        //Creamos un objeto de cliente de correo
        System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

        //Hay que crear las credenciales del correo emisor
        cliente.Credentials =
            new System.Net.NetworkCredential("jamillreyesf@gmail.com", "Soporte1");

        //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail
        
        cliente.Port = 587; // el puerto por donde envias el correo GMAIL
        cliente.EnableSsl = true; //habolilita la seguridad        

        cliente.Host = "smtp.gmail.com"; //Para Gmail "smtp.gmail.com";


        /*-------------------------ENVIO DE CORREO----------------------*/

        try
        {
            //Enviamos el mensaje      
            cliente.Send(mmsg);
        }
        //preguntar por esta libreria 
        catch (System.Net.Mail.SmtpException)
        {

            //Aquí gestionamos los errores al intentar enviar el correo
        }   
          

                _context.Add(d);    
            
           
                _context.SaveChanges();

 
                return RedirectToAction("Confirmacion");
            }
            
            return View(d);
        }
        public IActionResult Confirmacion()
        {
            return View();
        }
       
    }
}