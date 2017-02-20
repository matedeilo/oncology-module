using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleFichTratamientoEntity
    {
        public int IDDetalleFichaTratamiento { get; set; }
        public String Observaciones { get; set; }
        public DateTime FechaSesion { get; set; }
        public int NroSesion { get; set; }
        public String EstadoPaciente { get; set; }
        public int IDFichaTratamiento { get; set; }
        public int IDGuiaContingencia { get; set; }
        public int IDHojaPreparacion { get; set; }
    }
}
