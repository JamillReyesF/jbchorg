namespace jbchorg.Models
{
    public class Asociado
    {
        public int Id {get; set;}
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Correo { get; set; }
        public string Movil { get; set; }
        
        public string TipoAsociado { get; set; }
        public string GAcademico  { get; set; }
        
    }
}