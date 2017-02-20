
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;
namespace DataAccess
{
    public class HistoriaClinicaDA
    {
        #region Contenedor
        public List<HistoriaClinicaEntity> GetHistoriasClinicas()
        {
            List<HistoriaClinicaEntity> listadoHistoriasClinicas = new List<HistoriaClinicaEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoHistoriasClinicas = context.HistoriaClinica.Select(c => new HistoriaClinicaEntity()
                {
                    IDHistoriaClinica = c.IDHistoriaClinica,
                    Antecedentes = c.Antecedentes,
                    Padecimiento = c.Padecimiento,
                    IDPaciente = c.IDPaciente
                }).ToList();
            }
            return listadoHistoriasClinicas;
        }
        public void DeleteHistoriaClinica(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                HistoriaClinica objC = contex.HistoriaClinica.First(c => c.IDHistoriaClinica == id);
                contex.HistoriaClinica.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.HistoriaClinica).Reload();
            }
        }
        public HistoriaClinica FindbyID(int id)
        {
            HistoriaClinica objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.HistoriaClinica.First(c => c.IDHistoriaClinica == id);
            }
            return objc;
        }
        public void CreateHistoriaClinica(HistoriaClinica objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.HistoriaClinica.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.HistoriaClinica).Reload();
            }
        }
        public void UpdateHistoriaClinica(HistoriaClinica objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.HistoriaClinica.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.HistoriaClinica).Reload();

            }
        }
        #endregion
    }
}
