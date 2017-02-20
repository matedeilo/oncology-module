
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;
namespace DataAccess
{
    public class ProtocoloDA
    {
        #region Contenedor
        public List<ProtocoloEntity> GetProtocolos()
        {
            List<ProtocoloEntity> listadoProtocolos = new List<ProtocoloEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoProtocolos = context.Protocolo.Select(c => new ProtocoloEntity()
                {
                    IDProtocolo = c.IDProtocolo,
                    NombreProtocolo = c.NombreProtocolo
                }).ToList();
            }
            return listadoProtocolos;
        }
        public void DeleteProtocolo(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                Protocolo objC = contex.Protocolo.First(c => c.IDProtocolo == id);
                contex.Protocolo.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.Protocolo).Reload();
            }
        }
        public Protocolo FindbyID(int id)
        {
            Protocolo objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.Protocolo.First(c => c.IDProtocolo == id);
            }
            return objc;
        }
        public void CreateProtocolo(Protocolo objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Protocolo.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.Protocolo).Reload();
            }
        }
        public void UpdateProtocolo(Protocolo objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Protocolo.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.Protocolo).Reload();

            }
        }
        #endregion
    }
}
