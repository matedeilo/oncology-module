
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;
namespace DataAccess
{
    public class OrdenTransporteDA
    {
        #region OrdenTransporte
        public List<OrdenTransporteEntity> GetOrdenesTransporte()
        {
            List<OrdenTransporteEntity> listadoOrdenesTransporte = new List<OrdenTransporteEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoOrdenesTransporte = context.OrdenTransporte.Select(c => new OrdenTransporteEntity()
                {
                    IDOrdenTransporte = c.IDOrdenTransporte,
                    FechaTransporte = c.FechaTransporte,
                    NumeroContenedores = c.NumeroContenedores,
                    Comentario = c.Comentario,
                    IDEmpresa = c.IDEmpresa,
                    nombreEmpresa = c.NombreEmpresa,
                    estado = c.Estado
                }).ToList();
            }
            return listadoOrdenesTransporte;
        }
        public void DeleteOrdenTransporte(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                OrdenTransporte objC = contex.OrdenTransporte.First(c => c.IDOrdenTransporte == id);
                contex.OrdenTransporte.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.OrdenTransporte).Reload();
            }
        }
        public OrdenTransporte FindbyID(int id)
        {
            OrdenTransporte objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.OrdenTransporte.First(c => c.IDOrdenTransporte == id);
            }
            return objc;
        }
        public void CreateOrdenTransporte(OrdenTransporte objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.OrdenTransporte.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.OrdenTransporte).Reload();
            }
        }
        public void UpdateOrdenTransporte(OrdenTransporte objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.OrdenTransporte.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.OrdenTransporte).Reload();

            }
        }
        #endregion
    }
}
