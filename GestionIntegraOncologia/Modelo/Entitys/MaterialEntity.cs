using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MaterialEntity
    {
        public int IDMaterial { get; set; }
        public String Descripcion { get; set; }
        public String Presentacion { get; set; }
        public float Volumen { get; set; }
        public float Peso { get; set; }
    }
}
