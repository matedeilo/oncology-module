
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;
namespace DataAccess
{
    public class HojaPreparacionDA
    {
        #region HojaPreparacion
        public List<HojaPreparacionEntity> GetHojaPreparacion()
        {
            List<HojaPreparacionEntity> listadoHojasPreparacion = new List<HojaPreparacionEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoHojasPreparacion = context.HojaPreparacion.Select(c => new HojaPreparacionEntity()
                {
                    IDHojaPreparacion = c.IDHojaPreparacion,
                    FechaPreparacion = c.FechaPreparacion,
                    EstadoHoja = c.EstadoHoja,
                    CantidadResiduos = c.CantidadResiduos,
                    IDProtocolo = c.IDProtocolo
                }).ToList();
            }
            return listadoHojasPreparacion;
        }
        public void DeleteHojaPreparacion(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                HojaPreparacion objC = contex.HojaPreparacion.First(c => c.IDHojaPreparacion == id);
                contex.HojaPreparacion.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.HojaPreparacion).Reload();
            }
        }
        public HojaPreparacion FindbyID(int id)
        {
            HojaPreparacion objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.HojaPreparacion.First(c => c.IDHojaPreparacion == id);
            }
            return objc;
        }
        public void CreateHojaPreparacion(HojaPreparacion objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.HojaPreparacion.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.HojaPreparacion).Reload();
            }
        }
        public void UpdateHojaPreparacion(HojaPreparacion objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.HojaPreparacion.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.HojaPreparacion).Reload();

            }
        }

        public MaterialxPreparado obtenerMateriales(int id) {
            HojaPreparacion objc = null;
            Paciente objPaciente = null;
            HistoriaClinica objHistoriaClinica = null;
            DetalleHistoriaClinica objDetalleHistoria = null;
            FichaTratamiento objFichaTratamiento = null;
            DetalleFichaTratamiento objDetalleFicha = null;
            HojaPreparacion objHojaPreparacion = null;
            Protocolo objProtocolo = null;
            ProtocoloxPreparado objProtxPrep = null;
            Preparado objPreparado = null;
            MaterialxPreparado objMatxPrep = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objPaciente = contex.Paciente.First(c => c.IDPaciente == id);
                objHistoriaClinica = contex.HistoriaClinica.First(c=>c.IDPaciente == objPaciente.IDPaciente);
                objDetalleHistoria = contex.DetalleHistoriaClinica.First(c=>c.IDHistoriaClinica == objHistoriaClinica.IDHistoriaClinica);
                objFichaTratamiento = contex.FichaTratamiento.First(c=>c.IDDetalleHistoriaClinica == objDetalleHistoria.IDDetalleHistoriaClinica);
                objDetalleFicha = contex.DetalleFichaTratamiento.First(c=>c.IDFichaTratamiento == objFichaTratamiento.IDFichaTratamiento);
                objHojaPreparacion = contex.HojaPreparacion.First(c=>c.IDHojaPreparacion == objDetalleFicha.IDHojaPreparacion);
                objProtocolo = contex.Protocolo.First(c=>c.IDProtocolo == objHojaPreparacion.IDProtocolo);
                objProtxPrep = contex.ProtocoloxPreparado.First(c=>c.IDProtocolo == objProtocolo.IDProtocolo);
                objPreparado = contex.Preparado.First(c=>c.IDPreparado == objProtxPrep.IDPreparado);
                objMatxPrep = contex.MaterialxPreparado.First(c=>c.IDPreparado == objPreparado.IDPreparado);
            }

            return objMatxPrep;

        }

        #endregion
    }
}
