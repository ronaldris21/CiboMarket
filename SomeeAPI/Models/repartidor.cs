//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SomeeAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class repartidor
    {
        public int idRepartidor { get; set; }
        public string username { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string pass { get; set; }
        public string numTelefono { get; set; }
        public Nullable<float> salarioAcumulado { get; set; }
    }
}
