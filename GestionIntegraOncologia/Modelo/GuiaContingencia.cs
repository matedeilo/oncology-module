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
    
    public partial class GuiaContingencia
    {
        public GuiaContingencia()
        {
            this.DetalleFichaTratamiento = new HashSet<DetalleFichaTratamiento>();
        }
    
        public int IDGuiaContingencia { get; set; }
        public int TipoGuia { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<DetalleFichaTratamiento> DetalleFichaTratamiento { get; set; }
    }
}
