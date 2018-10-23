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
                //prueba ya que en mi maquina el net.mail no lo reconoce 
                //ya con este programita de internet he probado para el envio de correo a tu detinatario
                //tengo que enviar datos a la base de datos 
                
     System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

        //Direccion de correo electronico a la que queremos enviar el mensaje
        mmsg.To.Add("jesus_reyes@usmp.pe");

        //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

        //Asunto
        mmsg.Subject = "Registro de nuevo Asociado";
        mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

        //Direccion de correo electronico que queremos que reciba una copia del mensaje
        //mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

        //Cuerpo del Mensaje
        mmsg.Body = "Datos Personales :\n\tNombre : "+m.Nombre+"\n\tApellido Paterno: "+m.APaterno+
                    "\n\tApellido Materno : "+m.AMaterno+"\n\tCorreo : "+m.Correo+
                    "\n\tTelefono : "+m.Movil+
                    "\n\tAsunto : "+m.Asunto+"\n\t\t"+m.Descripcion;
        ;
        mmsg.BodyEncoding = System.Text.Encoding.UTF8;
        mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

        //Correo electronico desde la que enviamos el mensaje
        mmsg.From = new System.Net.Mail.MailAddress("romerochocano79@gmail.com");


        /*-------------------------CLIENTE DE CORREO----------------------*/

        //Creamos un objeto de cliente de correo
        System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

        //Hay que crear las credenciales del correo emisor
        cliente.Credentials =
            new System.Net.NetworkCredential("romerochocano79@gmail.com", "melissa1979");

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
        catch (System.Net.Mail.SmtpException ex)
        {
            //Aquí gestionamos los errores al intentar enviar el correo
        }   
          

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
