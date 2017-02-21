using Modelo;
using Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SistemaOncologia
{
    public partial class GenerarHojaPreparacionPage : System.Web.UI.Page
    {

        HojaPreparacionController hojaPreparacionController = new HojaPreparacionController();
        PacienteController pacienteController = new PacienteController();
        ProtocoloController protocoloController = new ProtocoloController();
        Paciente paciente = null;
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info("Iniciando Busqueda");
                 int dni = Int32.Parse(txtDniPaciente.Text);
                paciente = pacienteController.FindbyID(dni);
                lblPaciente.Text = paciente.Nombre + " " + paciente.ApellidoPaterno + " " + paciente.ApellidoMaterno;

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Nombre", typeof(string)),
                            new DataColumn("Apellidos", typeof(string)),
                            new DataColumn("Peso",typeof(float)),
                            new DataColumn("Edad",typeof(int))});
                dt.Rows.Add(paciente.Nombre,paciente.ApellidoPaterno+" "+paciente.ApellidoMaterno, paciente.Peso,paciente.Edad);
                grdPaciente.DataSource = dt;
                grdPaciente.DataBind();
           
            }
            catch (Exception ex)
            {
                log.Info("Excepcion: " + ex);
                throw;
            }
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
         
            int dni = Int32.Parse(txtDniPaciente.Text);
            paciente = pacienteController.FindbyID(dni);
            int edad = paciente.Edad;
            double peso = Convert.ToDouble(txtPeso.Text);
            String estado = txtEstadoPaciente.Text.ToString();
            int idPaciente = paciente.IDPaciente;
            List<Preparado> listaPreparado = hojaPreparacionController.getPreparados(edad, peso, estado, idPaciente);
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] {new DataColumn("Preparado", typeof(string)),
                            new DataColumn("Descripcion", typeof(string)),
                            new DataColumn("Presentacion", typeof(string)),
                            new DataColumn("Dosis",typeof(string))});
                    foreach (Preparado preparado in listaPreparado)
                    {
                            List<Material> materialesOptimizacion = hojaPreparacionController.getMaterialesOptimizacion(edad, peso, estado, idPaciente,preparado.IDPreparado);
                            List<string> dosisOptimizada = hojaPreparacionController.optimizarPreparado(edad, peso, estado, idPaciente,preparado.IDPreparado);
                             int contadorDosis = 0;
                            foreach (Material material in materialesOptimizacion)
                           {
                                 dt.Rows.Add(preparado.NombrePreparado,material.Descripcion, material.Presentacion, dosisOptimizada[contadorDosis] + " " + "gramos");
                                 grdHojaPreparacion.DataSource = dt;
                                 grdHojaPreparacion.DataBind();
                                 contadorDosis++;
                            }
                    }
       
            DateTime now = DateTime.Now;
            int idProtocolo = hojaPreparacionController.getProtocoloiD(idPaciente);
            HojaPreparacion hojaPreparación = new HojaPreparacion();
            hojaPreparación.IDProtocolo = idProtocolo;
            hojaPreparación.EstadoHoja = "Pendiente";
            hojaPreparación.FechaPreparacion = now;
            hojaPreparacionController.CreateHojaPreparacion(hojaPreparación);
        }
    }
}