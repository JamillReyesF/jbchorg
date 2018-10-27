using System.ComponentModel.DataAnnotations;
namespace jbchorg.Models
{
    public class Donacion
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Ingrese su Nombre")]
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese su Email")]
        public string Correo { get; set; }

        public string TipoAsociado { get; set; }
        public string GAcademico  { get; set; }
        public string Area { get; set; }
    }
}