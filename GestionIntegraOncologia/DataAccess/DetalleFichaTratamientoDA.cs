
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class DetalleFichaTratamientoDA
    {
        #region Contenedor
        public List<DetalleFichTratamientoEntity> GetDetalleFichaTratamiento()
        {
            List<DetalleFichTratamientoEntity> listadoDetalleFichaTratamiento = new List<DetalleFichTratamientoEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoDetalleFichaTratamiento = context.DetalleFichaTratamiento.Select(c => new DetalleFichTratamientoEntity()
                {
                    IDDetalleFichaTratamiento = c.IDDetalleFichaTratamiento,
                    Observaciones = c.Observaciones,
                    FechaSesion = c.FechaSesion,
                    NroSesion = c.NroSesion,
                    EstadoPaciente = c.EstadoPaciente,
                    IDFichaTratamiento = c.IDFichaTratamiento,
                    IDGuiaContingencia = c.IDGuiaContingencia,
                    IDHojaPreparacion = c.IDHojaPreparacion
  
                }).ToList();
            }
            return listadoDetalleFichaTratamiento;
        }
     
        public DetalleFichaTratamiento FindbyID(int id)
        {
            DetalleFichaTratamiento objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.DetalleFichaTratamiento.First(c => c.IDDetalleFichaTratamiento == id);

            }
            return objc;
        }

        public void FindMateriales(int id)
        {
            Paciente objc = null;
            Material objcm = null;
            HistoriaClinica objHistoria = null;
            DetalleHistoriaClinica objDetalleHistoria = null;
            FichaTratamiento objFichaTratamiento = null;
            DetalleFichaTratamiento objDetalleFichaTratamiento = null;
            HojaPreparacion objHojaPreparacion = null;
            Protocolo objProtocolo = null;
    
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.Paciente.First(c => c.IDPaciente == id);
                objHistoria = contex.HistoriaClinica.First(c=> c.IDPaciente == objc.IDPaciente);
                objDetalleHistoria = contex.DetalleHistoriaClinica.First(c=>c.IDHistoriaClinica == objHistoria.IDHistoriaClinica);
                objFichaTratamiento = contex.FichaTratamiento.First(c=>c.IDDetalleHistoriaClinica == objDetalleHistoria.IDDetalleHistoriaClinica);
                objDetalleFichaTratamiento = contex.DetalleFichaTratamiento.First(c=>c.IDFichaTratamiento == objFichaTratamiento.IDFichaTratamiento);
                objHojaPreparacion = contex.HojaPreparacion.First(c=>c.IDHojaPreparacion==objDetalleFichaTratamiento.IDHojaPreparacion);
                objProtocolo = contex.Protocolo.First(c=>c.IDProtocolo == objHojaPreparacion.IDProtocolo);
            }
           // return objc;
        }

        #endregion
    }
}