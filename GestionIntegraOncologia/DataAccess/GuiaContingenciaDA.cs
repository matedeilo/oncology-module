
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class GuiaContingenciaDA
    {
        #region GuiasContingencia
        public List<GuiaContingenciaEntity> GetGuias()
        {
            List<GuiaContingenciaEntity> listadoGuias = new List<GuiaContingenciaEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoGuias = context.GuiaContingencia.Select(c => new GuiaContingenciaEntity()
                {
                    IDGuiaContingencia = c.IDGuiaContingencia,
                    TipoGuia = c.TipoGuia,
                    Descripcion = c.Descripcion
                }).ToList();
            }
            return listadoGuias;
        }
        public void DeleteGuias(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                GuiaContingencia objC = contex.GuiaContingencia.First(c => c.IDGuiaContingencia == id);
                contex.GuiaContingencia.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.GuiaContingencia).Reload();
            }
        }
        public GuiaContingencia FindbyID(int id)
        {
            GuiaContingencia objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.GuiaContingencia.First(c => c.IDGuiaContingencia == id);
            }
            return objc;
        }
        public void CreateGuias(GuiaContingencia objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.GuiaContingencia.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.GuiaContingencia).Reload();
            }
        }
        public void UpdateGuias(GuiaContingencia objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.GuiaContingencia.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.GuiaContingencia).Reload();

            }
        }
        #endregion
    }
}
