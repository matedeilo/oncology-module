using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class OrdenTransporteEntity
    {
        public int IDOrdenTransporte { get; set; }
        public DateTime FechaTransporte { get; set; }
        public int NumeroContenedores { get; set; }
        public String Comentario { get; set; }
        public int IDEmpresa { get; set; }
    }
}
