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
    
    public partial class pedidos
    {
        public int idPedido { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idRepartidor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
        public Nullable<float> total { get; set; }
        public Nullable<float> xlat { get; set; }
        public Nullable<float> ylat { get; set; }
        public string comentarios { get; set; }
        public string estado { get; set; }
        public Nullable<float> puntajeServicio { get; set; }
        public string metodoPago { get; set; }
    }
}
