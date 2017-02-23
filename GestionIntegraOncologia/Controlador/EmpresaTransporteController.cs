using DataAccess;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class EmpresaTransporteController
    {
        private EmpresaTransporteDA objEmpresaTransporte = null;

        public EmpresaTransporteController()
        {
            objEmpresaTransporte = new EmpresaTransporteDA();
        }

        public List<EmpresaTransporteEntity> obtenerListadoEmpresasRankeadas()
        {
            return objEmpresaTransporte.GetEmpresasTransporte();
        }
    }
}
