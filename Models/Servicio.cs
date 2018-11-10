using System.ComponentModel.DataAnnotations;

namespace jbchorg.Models
{
    public class Servicio
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Ingrese el Servicio")]
        [StringLength(40, MinimumLength = 2)]
        public string NombreServ { get; set; }

        [Required(ErrorMessage = "Ingrese el tipo de Servicio")]   
         public string tipo {get; set;}
        [Required(ErrorMessage = "Ingrese el tipo de Servicio")]   
         public string descripcion { get;set;}
    }
}