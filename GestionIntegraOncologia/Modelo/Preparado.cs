//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
