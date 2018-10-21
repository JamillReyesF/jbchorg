
using System.ComponentModel.DataAnnotations;

namespace jbchorg.Models
{
    public class Mensaje
    {
        //ver si esta bien tipiado 
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese su Email")]
        public string Email { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string APaterno  { get; set; }
        public string ApellidoM  { get; set; }

        public string Celular { get; set; }
        public string Asunto  { get; set; }
        
        public string Descripcion { get; set; }

    }
}