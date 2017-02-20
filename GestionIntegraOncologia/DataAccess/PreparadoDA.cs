
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class PreparadoDA
    {
        #region Preparado
        public List<PreparadoEntity> GetPreparados()
        {
            List<PreparadoEntity> listadoPreparados = new List<PreparadoEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoPreparados = context.Preparado.Select(c => new PreparadoEntity()
                {
                    IDPreparado = c.IDPreparado,
                    NombrePreparado = c.NombrePreparado,
                    Preparacion = c.Preparacion
                }).ToList();
            }
            return listadoPreparados;
        }
        public void DeletePreparado(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                Preparado objC = contex.Preparado.First(c => c.IDPreparado == id);
                contex.Preparado.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.Preparado).Reload();
            }
        }
        public Preparado FindbyID(int id)
        {
            Preparado objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.Preparado.First(c => c.IDPreparado == id);
            }
            return objc;
        }
        public void CreatePreparado(Preparado objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Preparado.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.Preparado).Reload();
            }
        }
        public void UpdatePreparado(Preparado objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Preparado.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.Preparado).Reload();

            }
        }
        #endregion
    }
}
