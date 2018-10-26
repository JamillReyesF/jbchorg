using System.ComponentModel.DataAnnotations;
namespace jbchorg.Models
{
    public class Asociado
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Ingrese su Nombre")]
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Correo { get; set; }
        public string Movil { get; set; }
        public string TipoAsociado { get; set; }
        public string GAcademico  { get; set; }
        
    }
}