
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class MaterialxPreparadoDA
    {
        #region MaterialxPreparado
        public List<MaterialxPreparadoEntity> GetMaterialxPreparado()
        {
            List<MaterialxPreparadoEntity> listadoMaterialesxPreparado = new List<MaterialxPreparadoEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoMaterialesxPreparado = context.MaterialxPreparado.Select(c => new MaterialxPreparadoEntity()
                {
                    IDMaterial = c.IDMaterial,
                    IDPreparado = c.IDPreparado,
                    Dosis = c.Dosis
                }).ToList();
            }
            return listadoMaterialesxPreparado;
        }
        
        public MaterialxPreparado FindbyID(int idMaterial, int idPreparado)
        {
            MaterialxPreparado objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.MaterialxPreparado.First(c => c.IDMaterial == idMaterial &&  c.IDPreparado == idPreparado) ;
            }
            return objc;
        }
        public void CreateMaterialxPreparado(MaterialxPreparado objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.MaterialxPreparado.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.MaterialxPreparado).Reload();
            }
        }
        public void UpdateMaterialxPreparado(MaterialxPreparado objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.MaterialxPreparado.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.MaterialxPreparado).Reload();

            }
        }
        #endregion
    }
}
