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
