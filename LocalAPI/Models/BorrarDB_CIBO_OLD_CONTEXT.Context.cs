﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BorrarDB_Cibo_OldEntities : DbContext
    {
        public BorrarDB_Cibo_OldEntities()
            : base("name=BorrarDB_Cibo_OldEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<direcciones> direcciones { get; set; }
        public virtual DbSet<pedidos> pedidos { get; set; }
        public virtual DbSet<platillos> platillos { get; set; }
        public virtual DbSet<platillosPedidos> platillosPedidos { get; set; }
        public virtual DbSet<repartidor> repartidor { get; set; }
        public virtual DbSet<restaurante> restaurante { get; set; }
        public virtual DbSet<sucursales> sucursales { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
