using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EmpleadoEntity
    {
        public int IDEmpleado { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Turno { get; set; }
        public int  TipoEmpleado { get; set; }
    }
}
