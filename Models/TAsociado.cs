using System.Collections.Generic;
using jbchorg.Models;
namespace jbchorg.Models
{
    public class TAsociado
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public List<Asociado> Asociados {get;set;}
        public TAsociado(){
            Asociados = new List<Asociado>();
        }
    }
}