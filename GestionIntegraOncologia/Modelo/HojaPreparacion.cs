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
    
    public partial class HojaPreparacion
    {
        public HojaPreparacion()
        {
            this.DetalleFichaTratamiento = new HashSet<DetalleFichaTratamiento>();
            this.Empleado = new HashSet<Empleado>();
        }
    
        public int IDHojaPreparacion { get; set; }
        public System.DateTime FechaPreparacion { get; set; }
        public string EstadoHoja { get; set; }
        public Nullable<int> CantidadResiduos { get; set; }
        public int IDProtocolo { get; set; }
    
        public virtual ICollection<DetalleFichaTratamiento> DetalleFichaTratamiento { get; set; }
        public virtual Protocolo Protocolo { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
