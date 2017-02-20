
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class DetalleHistoriaClinicaDA
    {
        #region Contenedor
        public List<DetalleHistoriaClinicaEntity> GetContenedores()
        {
            List<DetalleHistoriaClinicaEntity> listadoDetallesHistoriaClinica = new List<DetalleHistoriaClinicaEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoDetallesHistoriaClinica = context.DetalleHistoriaClinica.Select(c => new DetalleHistoriaClinicaEntity()
                {
                    IDDetalleHistoriaClinica = c.IDDetalleHistoriaClinica,
                    FechaConsulta = c.FechaConsulta,
                    Motivo = c.Motivo,
                    IDHistoriaClinica = c.IDHistoriaClinica
                }).ToList();
            }
            return listadoDetallesHistoriaClinica;
        }
        public void DeleteDetalleHistoriaClinica(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                DetalleHistoriaClinica objC = contex.DetalleHistoriaClinica.First(c => c.IDDetalleHistoriaClinica == id);
                contex.DetalleHistoriaClinica.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.DetalleHistoriaClinica).Reload();
            }
        }
        public DetalleHistoriaClinica FindbyID(int id)
        {
            DetalleHistoriaClinica objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.DetalleHistoriaClinica.First(c => c.IDDetalleHistoriaClinica == id);
            }
            return objc;
        }
        public void CreateDetalleHistoriaClinica(DetalleHistoriaClinica objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.DetalleHistoriaClinica.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.DetalleHistoriaClinica).Reload();
            }
        }
        public void UpdateDetalleHistoriaClinica(DetalleHistoriaClinica objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.DetalleHistoriaClinica.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.DetalleHistoriaClinica).Reload();

            }
        }
        #endregion
    }
}
