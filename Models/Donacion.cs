using System.ComponentModel.DataAnnotations;
namespace jbchorg.Models
{
    public class Donacion
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Ingrese su Nombre")]
        public string Nombre { get; set; }
        public string DPaterno { get; set; }
        public string DMaterno { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese su Email")]
        public string Correo { get; set; }

        public string Banco { get; set; }
        public string NumTarj  { get; set; }
        public string Monto { get; set; }
    }
}