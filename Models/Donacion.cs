using System.ComponentModel.DataAnnotations;

namespace jbchorg.Models
{
    public class Donacion
    {
        public int Id {get; set;}
        
        //ver si esta bien tipiado 
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese su Email")]
        public string Correo { get; set; } 
        [Required(ErrorMessage = "Ingrese su Nombre")]
        public string Nombre { get; set; }
        public string APaterno  { get; set; }
        public string AMaterno { get; set; }
        public string Movil { get; set; }
        public string Monto { get; set; }
        public string Banco  { get; set; }
        public string Tarjeta { get; set; }
    }
}