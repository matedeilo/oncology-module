using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ContenedorEntity
    {
        public int IDContenedor { get; set; }
        public DateTime FechaSalida { get; set; }
        public String Observacion { get; set; }
        public String EstadoContenedor { get; set; }
        public int IDCFichaTratamiento { get; set; }

    }
}
