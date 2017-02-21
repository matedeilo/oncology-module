
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

        public List<Material> obtenerMateriales(int id, int idPreparado)
        {
            HojaPreparacion objc = null;
            Paciente objPaciente = null;
            HistoriaClinica objHistoriaClinica = null;
            DetalleHistoriaClinica objDetalleHistoria = null;
            FichaTratamiento objFichaTratamiento = null;
            DetalleFichaTratamiento objDetalleFicha = null;
            Protocolo objProtocolo = null;
            List<ProtocoloxPreparado> objProtxPrep = null;
            List<Preparado> listaPreparados = new List<Preparado>();
            List<MaterialxPreparado> objMatxPrep = new List<MaterialxPreparado>();
            List<Material> listaMateriales = new List<Material>();
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objPaciente = contex.Paciente.First(c => c.IDPaciente == id);
                objHistoriaClinica = contex.HistoriaClinica.First(c => c.IDPaciente == objPaciente.IDPaciente);
                objDetalleHistoria = contex.DetalleHistoriaClinica.First(c => c.IDHistoriaClinica == objHistoriaClinica.IDHistoriaClinica);
                objFichaTratamiento = contex.FichaTratamiento.First(c => c.IDDetalleHistoriaClinica == objDetalleHistoria.IDDetalleHistoriaClinica);
                objDetalleFicha = contex.DetalleFichaTratamiento.First(c => c.IDFichaTratamiento == objFichaTratamiento.IDFichaTratamiento);
                objProtocolo = contex.Protocolo.First(c => c.IDProtocolo == objDetalleFicha.IDProtocolo);
                objProtxPrep = contex.ProtocoloxPreparado.Where(c => c.IDProtocolo == objProtocolo.IDProtocolo).ToList();
                    objMatxPrep = contex.MaterialxPreparado.Where(c => c.IDPreparado == idPreparado).ToList();
                    foreach (MaterialxPreparado materialxPreparado in objMatxPrep)
                    {
                        listaMateriales.Add(materialxPreparado.Material);
                    }
            }

            return listaMateriales;

        }


        public List<Preparado> obtenerPreparaciones(int id)
        {
            Paciente objPaciente = null;
            HistoriaClinica objHistoriaClinica = null;
            DetalleHistoriaClinica objDetalleHistoria = null;
            FichaTratamiento objFichaTratamiento = null;
            DetalleFichaTratamiento objDetalleFicha = null;
            Protocolo objProtocolo = null;
            List<ProtocoloxPreparado> objProtxPrep = null;
            List<Preparado> listaPreparados = new List<Preparado>();
            List<MaterialxPreparado> objMatxPrep = new List<MaterialxPreparado>();
            List<Material> listaMateriales = new List<Material>();
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objPaciente = contex.Paciente.First(c => c.IDPaciente == id);
                objHistoriaClinica = contex.HistoriaClinica.First(c => c.IDPaciente == objPaciente.IDPaciente);
                objDetalleHistoria = contex.DetalleHistoriaClinica.First(c => c.IDHistoriaClinica == objHistoriaClinica.IDHistoriaClinica);
                objFichaTratamiento = contex.FichaTratamiento.First(c => c.IDDetalleHistoriaClinica == objDetalleHistoria.IDDetalleHistoriaClinica);
                objDetalleFicha = contex.DetalleFichaTratamiento.First(c => c.IDFichaTratamiento == objFichaTratamiento.IDFichaTratamiento);
                objProtocolo = contex.Protocolo.First(c => c.IDProtocolo == objDetalleFicha.IDProtocolo);
                objProtxPrep = contex.ProtocoloxPreparado.Where(c => c.IDProtocolo == objProtocolo.IDProtocolo).ToList();
                foreach (ProtocoloxPreparado protocoloxPreparado in objProtxPrep)
                {
                    listaPreparados.Add(protocoloxPreparado.Preparado);
                }

            }

            return listaPreparados;

        }

        public List<List<MaterialxPreparado>> obtenerMaterialesxPreparado(int id, int idPreparado)
        {
            HojaPreparacion objc = null;
            Paciente objPaciente = null;
            HistoriaClinica objHistoriaClinica = null;
            DetalleHistoriaClinica objDetalleHistoria = null;
            FichaTratamiento objFichaTratamiento = null;
            DetalleFichaTratamiento objDetalleFicha = null;
            Protocolo objProtocolo = null;
            List<ProtocoloxPreparado> objProtxPrep = null;
            List<Preparado> listaPreparados = new List<Preparado>();
            List<MaterialxPreparado> objMatxPrep = new List<MaterialxPreparado>();
            List<List<MaterialxPreparado>> listadoMaterialxPreparado = new List<List<MaterialxPreparado>>();
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objPaciente = contex.Paciente.First(c => c.IDPaciente == id);
                objHistoriaClinica = contex.HistoriaClinica.First(c => c.IDPaciente == objPaciente.IDPaciente);
                objDetalleHistoria = contex.DetalleHistoriaClinica.First(c => c.IDHistoriaClinica == objHistoriaClinica.IDHistoriaClinica);
                objFichaTratamiento = contex.FichaTratamiento.First(c => c.IDDetalleHistoriaClinica == objDetalleHistoria.IDDetalleHistoriaClinica);
                objDetalleFicha = contex.DetalleFichaTratamiento.First(c => c.IDFichaTratamiento == objFichaTratamiento.IDFichaTratamiento);
                objProtocolo = contex.Protocolo.First(c => c.IDProtocolo == objDetalleFicha.IDProtocolo);
                objProtxPrep = contex.ProtocoloxPreparado.Where(c => c.IDProtocolo == objProtocolo.IDProtocolo).ToList();
                 objMatxPrep = contex.MaterialxPreparado.Where(c => c.IDPreparado == idPreparado).ToList();
                listadoMaterialxPreparado.Add(objMatxPrep.ToList());

            }

            return listadoMaterialxPreparado;

        }


        public int obtenerProtocoloId(int id)
        {
            Paciente objPaciente = null;
            HistoriaClinica objHistoriaClinica = null;
            DetalleHistoriaClinica objDetalleHistoria = null;
            FichaTratamiento objFichaTratamiento = null;
            DetalleFichaTratamiento objDetalleFicha = null;
            int protocoloID = 0;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objPaciente = contex.Paciente.First(c => c.IDPaciente == id);
                objHistoriaClinica = contex.HistoriaClinica.First(c => c.IDPaciente == objPaciente.IDPaciente);
                objDetalleHistoria = contex.DetalleHistoriaClinica.First(c => c.IDHistoriaClinica == objHistoriaClinica.IDHistoriaClinica);
                objFichaTratamiento = contex.FichaTratamiento.First(c => c.IDDetalleHistoriaClinica == objDetalleHistoria.IDDetalleHistoriaClinica);
                objDetalleFicha = contex.DetalleFichaTratamiento.First(c => c.IDFichaTratamiento == objFichaTratamiento.IDFichaTratamiento);
                protocoloID = objDetalleFicha.IDProtocolo;
            }

            return protocoloID;

        }

        #endregion
    }
}
