//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocalAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class restaurante
    {
        public int idRes { get; set; }
        public string nombre { get; set; }
        public Nullable<float> rating { get; set; }
        public string imgLogo { get; set; }
        public Nullable<float> xlat { get; set; }
        public Nullable<float> ylon { get; set; }
        public string descp { get; set; }
        public string horaS { get; set; }
        public string horaE { get; set; }
        public string imgLaye { get; set; }
        public string pass { get; set; }
        public string PersonaEncargada { get; set; }
        public string NumTelefono { get; set; }
    }
}
