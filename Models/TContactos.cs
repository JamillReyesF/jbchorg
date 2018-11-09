using System.ComponentModel.DataAnnotations;
using jbchorg.Models;
using System;
using System.Collections.Generic;

namespace jbchorg.Models
{
    public class TContactos
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Correo{get;set;}
        public List<Mensaje> Contactos{get;set;}
        public TContactos(){
            Mensaje = new List<Mensaje>();
        }
    }
}