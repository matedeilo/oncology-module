﻿using Modelo;
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
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
                Console.WriteLine("ex");
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
            double dosisOptimizada = hojaPreparacionController.optimizarPreparado(edad,peso,estado,idPaciente);

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Descripcion", typeof(string)),
                            new DataColumn("Presentacion", typeof(string)),
                            new DataColumn("Dosis",typeof(double))});
            dt.Rows.Add(hojaPreparacionController.getMaterialxPreparado(idPaciente).Descripcion
                , hojaPreparacionController.getMaterialxPreparado(idPaciente).Presentacion, dosisOptimizada);
            grdHojaPreparacion.DataSource = dt;
            grdHojaPreparacion.DataBind();
        }
    }
}