﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Distribuidora.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class distribuidoraEntities : DbContext
    {
        public distribuidoraEntities()
            : base("name=distribuidoraEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<dia> dia { get; set; }
        public DbSet<movimiento> movimiento { get; set; }
        public DbSet<ruta> ruta { get; set; }
        public DbSet<tarjeta> tarjeta { get; set; }
        public DbSet<tipomovimiento> tipomovimiento { get; set; }
    
        public virtual ObjectResult<SaldoPorRuta_Result> SaldoPorRuta(Nullable<int> parametro)
        {
            var parametroParameter = parametro.HasValue ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SaldoPorRuta_Result>("SaldoPorRuta", parametroParameter);
        }
    }
}