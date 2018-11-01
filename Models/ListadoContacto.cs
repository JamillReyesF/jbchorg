

using System.ComponentModel.DataAnnotations;

namespace jbchorg.Models
{
    // aqui mando los atributos que van a figurar en pagina de listado de contacto en la vista
   public class ListadeContactos
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string correo{ get; set; }
    }

}