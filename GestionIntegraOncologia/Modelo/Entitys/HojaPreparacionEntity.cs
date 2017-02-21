using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class HojaPreparacionEntity
    {
        public int IDHojaPreparacion { get; set; }
        public DateTime FechaPreparacion { get; set; }
        public String EstadoHoja { get; set; }
        public int? CantidadResiduos { get; set; }
        public int IDProtocolo { get; set; }
    }
}
