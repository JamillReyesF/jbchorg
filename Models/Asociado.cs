using System.ComponentModel.DataAnnotations;
namespace jbchorg.Models
{
    public class Asociado
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Ingrese su Nombre")]
        [StringLength(20)]
        public string Nombre { get; set; }
        [StringLength(20)]
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese su Email")]
        public string Correo { get; set; }
        public string TAsociado{get;set;}
        public string GAcademico  { get; set; }
        public string Area { get; set; }
        
    }
}