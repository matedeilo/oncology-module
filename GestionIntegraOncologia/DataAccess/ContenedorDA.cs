
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class ContenedorDA
    {
        #region Contenedor
        public List<ContenedorEntity> GetContenedores()
        {
            List<ContenedorEntity> listadoContenedores = new List<ContenedorEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoContenedores = context.Contenedor.Select(c => new ContenedorEntity()
                {
                    IDContenedor = c.IDContenedor,
                    FechaSalida = c.FechaSalida,
                    Observacion = c.Observacion,
                    EstadoContenedor = c.EstadoContenedor,
                    IDCFichaTratamiento = c.IDFichaTratamiento
                }).ToList();
                listadoContenedores = listadoContenedores.Where(c=> c.EstadoContenedor.Equals("Nuevo")).ToList();
            }
            
            return listadoContenedores;
        }
        public void DeleteCotenedor(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                Contenedor objC = contex.Contenedor.First(c => c.IDContenedor == id);
                contex.Contenedor.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.Contenedor).Reload();
            }
        }
        public Contenedor FindbyID(int id)
        {
            Contenedor objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.Contenedor.First(c => c.IDContenedor == id);
            }
            return objc;
        }
        public void CreateContenedor(Contenedor objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Contenedor.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.Contenedor).Reload();
            }
        }
        public void UpdateContenedor(Contenedor objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Contenedor.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.Contenedor).Reload();

            }
        }
        #endregion
    }

}
