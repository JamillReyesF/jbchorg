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

//me sale que el net la version es antiga 
// en  mi carpeta particualar que trabajo si corre y se muestra el formulario de contacto
//ver si en esta caropeta hago mi constructor para llamar a mi moledo y vista de listar contacto
    public class ContactoController : Controller
    {
        private readonly JbchorgDBContext context;


        public ContactoController(JbchorgDBContext c){
            context = c;
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
                    "\n\tAsunto : "+m.Asunto+
                    "\n\tDescripcion: "+m.Descripcion;
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
          

                context.Add(m);    
            
           
                context.SaveChanges();

 
                return RedirectToAction("Confirmacion");
            }
            
            return View(m);
        }
        public IActionResult Confirmacion()
        {
            return View();
        }

//aumentar en la base de datos para mi listado y hacer la busqueda de contactos

       


        
       
    }
}
