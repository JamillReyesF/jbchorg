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
        [Required(ErrorMessage = "Ingrese su Apellido Paterno")]
        public string APaterno  { get; set; }
        [Required(ErrorMessage = "Ingrese su Apellido Materno")]
        public string AMaterno { get; set; }
        [Required(ErrorMessage = "Ingrese su DNI")]
        public string DNI { get; set; }
        [Required(ErrorMessage = "Ingrese su Movil")]
        public string Movil { get; set; }
        [Required(ErrorMessage = "Ingrese el Monto")]
        public string Monto { get; set; }
        [Required(ErrorMessage = "Ingrese el Banco")]
        public string Banco  { get; set; }
        [Required(ErrorMessage = "Ingrese su Número de Tarjeta")]
        public string Tarjeta { get; set; }
    }
}