using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PacienteEntity
    {
        public int IDPaciente { get; set; }
        public String Nombre { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public int DNI { get; set; }
        public int Edad { get; set; }
        public int Sexo { get; set; }
        public double  Peso { get; set; }
        public int Estado { get; set; }
    }
}
