
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using System.Data.Objects;

namespace DataAccess
{
    public class EmpleadoDA
    {
        #region Contenedor
        public List<EmpleadoEntity> GetEmpleados()
        {
            List<EmpleadoEntity> listadoEmpleados = new List<EmpleadoEntity>();
            using (OncologiaEntities context = new OncologiaEntities())
            {
                listadoEmpleados = context.Empleado.Select(c => new EmpleadoEntity()
                {
                    IDEmpleado = c.IDEmpleado,
                    Nombre = c.Nombre,
                    Apellido = c.Apellido,
                    Turno = c.Turno,
                    TipoEmpleado = c.TipoEmpleado
                }).ToList();
            }
            return listadoEmpleados;
        }
        public void DeleteEmpleado(int id)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {

                Empleado objC = contex.Empleado.First(c => c.IDEmpleado == id);
                contex.Empleado.Remove(objC);
                contex.SaveChanges();
                contex.Entry(contex.Empleado).Reload();
            }
        }
        public Empleado FindbyID(int id)
        {
            Empleado objc = null;
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                objc = contex.Empleado.First(c => c.IDEmpleado == id);
            }
            return objc;
        }
        public void CreateEmpleado(Empleado objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Empleado.Add(objC);
                contex.SaveChanges();
                contex.Entry(contex.Empleado).Reload();
            }
        }
        public void UpdateEmpleado(Empleado objC)
        {
            using (OncologiaEntities contex = new OncologiaEntities())
            {
                contex.Empleado.Attach(objC);
                contex.Entry(objC).State = EntityState.Modified;
                contex.SaveChanges();
                contex.Entry(contex.Empleado).Reload();

            }
        }
        #endregion
    }
}
