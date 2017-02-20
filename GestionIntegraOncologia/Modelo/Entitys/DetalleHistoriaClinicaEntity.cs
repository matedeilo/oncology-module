using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleHistoriaClinicaEntity
    {
        public int IDDetalleHistoriaClinica { get; set; }
        public DateTime FechaConsulta { get; set; }
        public String Motivo { get; set; }
        public int IDHistoriaClinica { get; set; }
    }
}
