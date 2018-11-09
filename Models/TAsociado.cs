using System.ComponentModel.DataAnnotations;
using jbchorg.Models;
using System;
using System.Collections.Generic;

namespace jbchorg.Models
{
    public class TAsociado
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public List<Asociado> Asociados{get;set;}
        public TAsociado(){
            Asociados = new List<Asociado>();
        }
    }
}