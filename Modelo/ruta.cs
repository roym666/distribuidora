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
    
    public partial class ruta
    {
        public ruta()
        {
            this.tarjeta = new HashSet<tarjeta>();
        }
    
        public short idRuta { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public Nullable<sbyte> idDia { get; set; }
    
        public virtual dia dia { get; set; }
        public virtual ICollection<tarjeta> tarjeta { get; set; }
    }
}
