
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;
namespace DataAccess
{
    public class PacienteDA
    {
        #region Paciente
        public List<PacienteEntity> GetPacientes()
        {
            List<PacienteEntity> listadoPacientes = new List<PacienteEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoPacientes = context.Paciente.Select(c => new PacienteEntity()
                {
                    IDPaciente = c.IDPaciente,
                    Nombre = c.Nombre,
                    ApellidoPaterno = c.ApellidoPaterno,
                    ApellidoMaterno = c.ApellidoMaterno,
                    DNI = c.DNI,
                    Edad = c.Edad,
                    Peso = c.Peso,
                    Estado = c.Estado
                }).ToList();
            }
            return listadoPacientes;
        }
        public void DeletePaciente(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                Paciente objC = contex.Paciente.First(c => c.IDPaciente == id);
                contex.Paciente.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.Paciente).Reload();
            }
        }
        public Paciente FindbyID(int id)
        {
            Paciente objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.Paciente.First(c => c.DNI == id);
            }
            return objc;
        }
        public void CreatePaciente(Paciente objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Paciente.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.Paciente).Reload();
            }
        }
        public void UpdatePaciente(Paciente objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Paciente.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.Paciente).Reload();

            }
        }
        #endregion
    }
}
