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
    
    public partial class sucursales
    {
        public int idSucursal { get; set; }
        public Nullable<int> idRestaurante { get; set; }
        public string nombre_sucursal { get; set; }
        public string departamento { get; set; }
        public string municipio { get; set; }
        public string lugar_referencia { get; set; }
        public Nullable<float> ylon { get; set; }
        public Nullable<float> xlat { get; set; }
        public string encargado { get; set; }
        public string password { get; set; }
    }
}
