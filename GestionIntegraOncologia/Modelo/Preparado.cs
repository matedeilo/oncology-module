//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Preparado
    {
        public Preparado()
        {
            this.MaterialxPreparado = new HashSet<MaterialxPreparado>();
            this.ProtocoloxPreparado = new HashSet<ProtocoloxPreparado>();
        }
    
        public int IDPreparado { get; set; }
        public string NombrePreparado { get; set; }
        public string Preparacion { get; set; }
    
        public virtual ICollection<MaterialxPreparado> MaterialxPreparado { get; set; }
        public virtual ICollection<ProtocoloxPreparado> ProtocoloxPreparado { get; set; }
    }
}
