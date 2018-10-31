using System.Collections.Generic;
namespace jbchorg.Models
{
    public class TAsociado
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public List<Asociado> Asociado {get;set;}
        public TAsociado(){
            Asociado = new List<Asociado>();
        }
    }
}