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
    
    public partial class ProtocoloxPreparado
    {
        public int IDProtocolo { get; set; }
        public int IDPreparado { get; set; }
    
        public virtual Preparado Preparado { get; set; }
        public virtual Protocolo Protocolo { get; set; }
        public virtual ProtocoloxPreparado ProtocoloxPreparado1 { get; set; }
        public virtual ProtocoloxPreparado ProtocoloxPreparado2 { get; set; }
    }
}
