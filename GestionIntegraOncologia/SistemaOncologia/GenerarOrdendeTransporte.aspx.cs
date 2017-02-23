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
    public partial class Generar_Orden_de_Transporte : System.Web.UI.Page
    {
        OrdenTransporteController ordenTransporteController = new OrdenTransporteController();
        EmpresaTransporteController empresaTransporteController = new EmpresaTransporteController();
        ContenedorController contenedorController = new ContenedorController();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5] {new DataColumn("Ranking", typeof(int)),
                            new DataColumn("Nombre", typeof(string)),
                            new DataColumn("RUC", typeof(int)),
                            new DataColumn("Telefono", typeof(int)),
                            new DataColumn("Seleccionar", typeof(LinkButton))});
            int contador = 1;
            List<EmpresaTransporteEntity> listadoEmpresasTransporte = empresaTransporteController.obtenerListadoEmpresasRankeadas();
            foreach (EmpresaTransporteEntity empresaTransporte in listadoEmpresasTransporte)
            {
                dt.Rows.Add(contador,empresaTransporte.Nombre, empresaTransporte.RUC, empresaTransporte.Telefono);
                grdEmpresaTransporte.DataSource = dt;
                grdEmpresaTransporte.DataBind();
                contador++;
            }
        }

        protected void btnContenedores_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] {new DataColumn("id", typeof(int)),
                            new DataColumn("Fecha Registro", typeof(DateTime))});
            List<ContenedorEntity> listadoContenedores = contenedorController.GetContenedores();
            foreach (ContenedorEntity contenedor in listadoContenedores)
            {
                dt.Rows.Add(contenedor.IDContenedor, contenedor.FechaSalida);
                grdContenedores.DataSource = dt;
                grdContenedores.DataBind();
            }
        }

        protected void btnGenerarOrden_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            OrdenTransporte ordenTransporte = new OrdenTransporte();
            ordenTransporte.IDEmpresa = 0;
            ordenTransporte.FechaTransporte = fecha;
            ordenTransporte.NumeroContenedores = 0;
            ordenTransporte.IDEmpresa = 0;
            ordenTransporte.NombreEmpresa = "";
            ordenTransporte.Estado = "Registrado";
            ordenTransporteController.CreateOrdenTransporte(ordenTransporte);
        }
    }
}