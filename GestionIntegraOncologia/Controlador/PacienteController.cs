using DataAccess;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controlador
{
    public class PacienteController
    {
        private PacienteDA objPaciente = null;
        public PacienteController()
        {
            objPaciente = new PacienteDA();
        }
        public List<PacienteEntity> GetPacientes()
        {
            return objPaciente.GetPacientes();
        }
     
        public Paciente FindbyID(int id)
        {
            return objPaciente.FindbyID(id);
        }

        public void UpdatePaciente(Paciente objC)
        {
            objPaciente.UpdatePaciente(objC);
        }

        public bool pacienteExiste(int dni)
        {
            bool existe = objPaciente.pacienteExiste(dni);
            return existe;
        }
    }
}
