
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class MaterialDA
    {
        #region Materiales
        public List<MaterialEntity> GetMateriales()
        {
            List<MaterialEntity> listadoMateriales = new List<MaterialEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoMateriales = context.Material.Select(c => new MaterialEntity()
                {
                    IDMaterial = c.IDMaterial,
                    Descripcion = c.Descripcion,
                    Presentacion = c.Presentacion
                    //Volumen = c.Volumen,
                   // Peso = c.Peso
                }).ToList();
            }
            return listadoMateriales;
        }
        public void DeleteMaterial(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                Material objC = contex.Material.First(c => c.IDMaterial == id);
                contex.Material.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.Material).Reload();
            }
        }
        public Material FindbyID(int id)
        {
            Material objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.Material.First(c => c.IDMaterial == id);
            }
            return objc;
        }
        public void CreateMaterial(Material objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Material.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.Material).Reload();
            }
        }
        public void UpdateMaterial(Material objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Material.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.Material).Reload();

            }
        }
        #endregion
    }
}
