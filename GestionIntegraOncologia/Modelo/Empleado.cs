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
    
    public partial class Empleado
    {
        public Empleado()
        {
            this.FichaTratamiento = new HashSet<FichaTratamiento>();
            this.HojaPreparacion = new HashSet<HojaPreparacion>();
        }
    
        public int IDEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Turno { get; set; }
        public int TipoEmpleado { get; set; }
    
        public virtual ICollection<FichaTratamiento> FichaTratamiento { get; set; }
        public virtual ICollection<HojaPreparacion> HojaPreparacion { get; set; }
    }
}