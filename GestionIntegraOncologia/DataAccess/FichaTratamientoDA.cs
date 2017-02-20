
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class FichaTratamientoDA
    {
        #region FichaTratamiento
        public List<FichaTratamientoEntity> GetFichaTratamiento()
        {
            List<FichaTratamientoEntity> listadoFichasTratamiento = new List<FichaTratamientoEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoFichasTratamiento = context.FichaTratamiento.Select(c => new FichaTratamientoEntity()
                {
                    IDFichaTratamiento = c.IDFichaTratamiento,
                    EstadoFicha = c.EstadoFicha,
                    NroSesiones = c.NroSesiones,
                    IntervaloSesion = c.IntervaloSesion,
                    Diagnostico = c.Diagnostico,
                    PlanAlimentacion = c.PlanAlimentacion,
                    EscalaActividad = c.EscalaActividad,
                    IDDetalleHistoriaClinica = c.IDDetalleHistoriaClinica
                    //IDEmpleado = IDe
                }).ToList();
            }
            return listadoFichasTratamiento;
        }
        public void DeleteFichaTratamiento(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                FichaTratamiento objC = contex.FichaTratamiento.First(c => c.IDFichaTratamiento == id);
                contex.FichaTratamiento.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.FichaTratamiento).Reload();
            }
        }
        public FichaTratamiento FindbyID(int id)
        {
            FichaTratamiento objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.FichaTratamiento.First(c => c.IDFichaTratamiento == id);
            }
            return objc;
        }
        public void CreateFichaTratamiento(FichaTratamiento objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.FichaTratamiento.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.FichaTratamiento).Reload();
            }
        }
        public void UpdateFichaTratamiento(FichaTratamiento objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.FichaTratamiento.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.FichaTratamiento).Reload();

            }
        }
        #endregion
    }
}
