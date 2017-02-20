using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class FichaTratamientoEntity
    {
        public int IDFichaTratamiento { get; set; }
        public String EstadoFicha { get; set; }
        public int NroSesiones { get; set; }
        public int IntervaloSesion { get; set; }
        public String Diagnostico { get; set; }
        public String PlanAlimentacion { get; set; }
        public String EscalaActividad { get; set; }
        public int IDDetalleHistoriaClinica { get; set; }
        public int IDEmpleado { get; set; }
    }
}
