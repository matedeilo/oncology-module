using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EmpresaTransporteEntity
    {
        public int IDEmpresa { get; set; }
        public String Nombre { get; set; }
        public int Telefono { get; set; }
        public int RUC { get; set; }
        public int NroObservaciones { get; set; }
        public DateTime FechaInicioActividades { get; set; }
        public double CostoViaje { get; set; }
    }
}
