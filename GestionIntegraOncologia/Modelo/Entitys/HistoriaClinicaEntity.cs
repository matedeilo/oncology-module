using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class HistoriaClinicaEntity
    {
        public int IDHistoriaClinica { get; set; }
        public String Antecedentes { get; set; }
        public String Padecimiento { get; set; }
        public int IDPaciente { get; set; }

    }
}
