using System.ComponentModel.DataAnnotations;

namespace jbchorg.Models
{
    public class Servicio
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Ingrese el Servicio")]
        [StringLength(150, MinimumLength = 2)]
        public string NombreServ { get; set; }

        [Required(ErrorMessage = "Ingrese el tipo de Servicio")]
        [StringLength(150, MinimumLength = 2)]   
         public string tipo {get; set;}
         
        [Required(ErrorMessage = "Ingrese la descripcion")]   
        [StringLength(150, MinimumLength = 2)]
         public string descripcion { get;set;}
    }
}