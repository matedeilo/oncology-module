using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class GuiaContingenciaEntity
    {
        public int IDGuiaContingencia { get; set; }
        public int TipoGuia { get; set; }
        public int IntervaloSesion { get; set; }
        public String Descripcion { get; set; }
    }
}
