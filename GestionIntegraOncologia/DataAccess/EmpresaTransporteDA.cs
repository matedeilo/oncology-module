
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class EmpresaTransporteDA
    {
        #region Contenedor
        public List<EmpresaTransporteEntity> GetEmpresasTransporte()
        {
            List<EmpresaTransporteEntity> listadoEmpresasTransporte = new List<EmpresaTransporteEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoEmpresasTransporte = context.EmpresaTransporte.Select(c => new EmpresaTransporteEntity()
                {
                    IDEmpresa = c.IDEmpresa,
                    Nombre = c.Nombre,
                    Telefono = c.Telefono,
                    RUC = c.RUC,
                    NroObservaciones = c.NroObservaciones
                    //FechaInicioActividades = c.FechaInicioActividades,
                    //CostoViaje = c.CostoViaje
                }).ToList();
            }
            return listadoEmpresasTransporte;
        }
        public void DeleteEmpresaTransporte(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                EmpresaTransporte objC = contex.EmpresaTransporte.First(c => c.IDEmpresa == id);
                contex.EmpresaTransporte.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.EmpresaTransporte).Reload();
            }
        }
        public EmpresaTransporte FindbyID(int id)
        {
            EmpresaTransporte objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.EmpresaTransporte.First(c => c.IDEmpresa == id);
            }
            return objc;
        }
        public void CreateEmpresaTransporte(EmpresaTransporte objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.EmpresaTransporte.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.EmpresaTransporte).Reload();
            }
        }
        public void UpdateEmpresaTransporte(EmpresaTransporte objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.EmpresaTransporte.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.EmpresaTransporte).Reload();

            }
        }
        #endregion
    }
}
