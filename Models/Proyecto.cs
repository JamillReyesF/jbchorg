using System.ComponentModel.DataAnnotations;
using System;
namespace jbchorg.Models
{
    public class Proyecto
    {
         public int Id {get; set;}
        [Required(ErrorMessage = "Ingrese el nombre de proyecto")]
        [StringLength(50, MinimumLength = 2)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese la fecha de fin del proyecto")]
        public DateTime Duracion {get;set;}
        [Required(ErrorMessage = "Ingrese una descripción del proyecto")]
        [StringLength(1000, MinimumLength = 10)]
        public string Descripcion { get; set; }
    }  
} 