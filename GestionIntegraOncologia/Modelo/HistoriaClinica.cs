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
    
    public partial class HistoriaClinica
    {
        public HistoriaClinica()
        {
            this.DetalleHistoriaClinica = new HashSet<DetalleHistoriaClinica>();
            this.FichaTratamiento = new HashSet<FichaTratamiento>();
        }
    
        public int IDHistoriaClinica { get; set; }
        public string Antecedentes { get; set; }
        public string Padecimiento { get; set; }
        public int IDPaciente { get; set; }
    
        public virtual ICollection<DetalleHistoriaClinica> DetalleHistoriaClinica { get; set; }
        public virtual ICollection<FichaTratamiento> FichaTratamiento { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
