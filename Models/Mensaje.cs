using System.ComponentModel.DataAnnotations;

namespace jbchorg.Models
{
    public class Mensaje
    {
        [EmailAddress]
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Movil { get; set; }
        public string Asunto { get; set; }
        public string Texto { get; set; }
    }
}