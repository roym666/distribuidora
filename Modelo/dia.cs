//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class dia
    {
        public dia()
        {
            this.ruta = new HashSet<ruta>();
        }
    
        public sbyte idDia { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<ruta> ruta { get; set; }
    }
}
