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
        EmpresaTransporte empresaTransporte = null;
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
            int numeroContenedores = 0;
            foreach (GridViewRow row in grdContenedores.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkCtrl") as CheckBox);
                    if (chkRow.Checked)
                    {
                        numeroContenedores++;
                    }
                }
            }
            empresaTransporte = getEmpresa();
            DateTime fecha = DateTime.Now;
            OrdenTransporte ordenTransporte = new OrdenTransporte();
            ordenTransporte.FechaTransporte = fecha;
            ordenTransporte.NumeroContenedores = numeroContenedores;
            ordenTransporte.IDEmpresa = empresaTransporte.IDEmpresa;
            ordenTransporte.NombreEmpresa = empresaTransporte.Nombre;
            ordenTransporte.Estado = "Registrado";
            ordenTransporte.Comentario =txtSustento.Text;
            ordenTransporteController.CreateOrdenTransporte(ordenTransporte);
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] {new DataColumn("Nombre Empresa Transporte", typeof(string)),
                            new DataColumn("Fecha Transporte", typeof(DateTime)),
                            new DataColumn("Numero Contenedores", typeof(int)),
                            new DataColumn("Estado Orden", typeof(string))});
                dt.Rows.Add(ordenTransporte.NombreEmpresa, ordenTransporte.FechaTransporte,ordenTransporte.NumeroContenedores,ordenTransporte.Estado);
                grdOrdenTransporte.DataSource = dt;
                grdOrdenTransporte.DataBind();
        }

        protected void grdEmpresaTransporte_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                Int16 num = Convert.ToInt16(e.CommandArgument);
                int ranking = Convert.ToInt16(grdEmpresaTransporte.Rows[num].Cells[1].Text);
                empresaTransporte = empresaTransporteController.findByNombre(grdEmpresaTransporte.Rows[num].Cells[2].Text);
                grdEmpresaTransporte.Rows[num].BackColor = System.Drawing.Color.Cyan;
                if (ranking != 1)
                {
                    lblcomentario.Visible = true;
                    txtSustento.Visible = true;
                }
                else {
                    lblcomentario.Visible = false;
                    txtSustento.Visible = false;
                }
            }
        }

        protected EmpresaTransporte getEmpresa()
        {
             empresaTransporte = empresaTransporteController.findByNombre(grdEmpresaTransporte.SelectedRow.Cells[2].Text);
            return empresaTransporte;
        }
    }
}