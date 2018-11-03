using System.ComponentModel.DataAnnotations;
namespace jbchorg.Models
{
    public class Proyecto
    {
         public int Id {get; set;}
        [Required(ErrorMessage = "Ingrese el nombre de proyecto")]
        [StringLength(50, MinimumLength = 2)]
        public string Nombre { get; set; }
        public string Duracion{get;set;}
        [Required(ErrorMessage = "Ingrese una descripción del proyecto")]
        [StringLength(1000, MinimumLength = 10)]
        public string Descripcion { get; set; }
    }
}