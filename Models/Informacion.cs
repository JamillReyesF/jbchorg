
using System.ComponentModel.DataAnnotations;

namespace jbchorg.Models
{

    //continuar modificando el diseño
    public class Informacion
    {
        public int Id {get; set;}
        
        //ver si esta bien tipiado 
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese su Email")]
        public string Correo { get; set; } 
        [Required(ErrorMessage = "Ingrese su Nombre")]
        public string Nombre { get; set; }
        public string EstadoCivil { get; set; }
        public string Investigador { get; set; }

        public int Dona1 { get; set; }
        public int Dona2 { get; set; }
        public double Result { get; set; }
              
        public string Asunto  { get; set; }
        public string Descripcion { get; set; }

    }
}