//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CiboMarket.Models
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