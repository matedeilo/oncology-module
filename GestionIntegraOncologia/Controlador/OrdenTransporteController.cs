using DataAccess;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class OrdenTransporteController
    {
        private OrdenTransporteDA objOrdenTransporte= null;
        public OrdenTransporteController()
        {
            objOrdenTransporte = new OrdenTransporteDA();
        }
        public List<OrdenTransporteEntity> GetOrdenesTransporte()
        {
            return objOrdenTransporte.GetOrdenesTransporte();
        }
        public void DeleteOrdenTransporte(int id)
        {
            objOrdenTransporte.DeleteOrdenTransporte(id);
        }
        public OrdenTransporte FindbyID(int id)
        {
            return objOrdenTransporte.FindbyID(id);
        }
        public void CreateOrdenTransporte(OrdenTransporte objC)
        {
            objOrdenTransporte.CreateOrdenTransporte(objC);
        }
        public void UpdateOrdenTransporte(OrdenTransporte objC)
        {
            objOrdenTransporte.UpdateOrdenTransporte(objC);
        }

    }
}

