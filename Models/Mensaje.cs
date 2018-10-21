using System.ComponentModel.DataAnnotations;

namespace jbchorg.Models
{
    public class Mensaje
    {
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese su Email")]
        public string Correo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Movil { get; set; }
        public string Asunto { get; set; }
        public string Texto { get; set; }
    }
}