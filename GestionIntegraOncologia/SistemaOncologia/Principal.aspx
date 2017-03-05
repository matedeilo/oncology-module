<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="SistemaOncologia.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Generacion de hoja de Preparacion</title>
</head>
<body>
       <form id="form1" runat="server">
    <div class="jumbotron">
        <div class="row">
            <div class="col-lg-2 col-md-2 col-sm-2" style="padding-right">
                <img style="float:right;" src="http://www.crp.com.pe/m/img/logocrp.gif"  height="70px" width="150px"/> 
            </div>
            <div style="text-align:center" class="col-lg-10 col-md-10 col-sm-10">
                <h2>Sistema Integral Oncologico Clinica Ricardo Palma</h2> 
            </div>
            
        </div>
    </div>
    
    <div class="container">
        <div class="page-header">
            <h1>Opciones</h1>
        </div>
        <p>
            <asp:Button Cssclass="btn btn-info" BorderStyle="Double" ID="btnGenerarHojaPreparacion" runat="server" OnClick="btnBuscarPaciente_Click" Text="Generar Hoja de Preparacion"  />
           
            <asp:Button Cssclass="btn btn-info" BorderStyle="Double" ID="btnGenerarOrdenTransporte" runat="server" OnClick="btnGenerarOrdenTransporte_Click" Text="Generar Orden de Transporte" /> 

            <asp:Button Cssclass="btn btn-info" BorderStyle="Double" ID="btnActualizarPreparacionMezclaCitostatica" runat="server" OnClick="btnActualizarPreparacionMezclaCitostatica_Click" Text="Actualizar Preparación de Mezclas Citostáticas" /> 

            <asp:Button Cssclass="btn btn-info" BorderStyle="Double" ID="btnActualizaFichaTratamiento" runat="server" OnClick="btnActualizaFichaTratamiento_Click" Text="Actualizar Ficha de Tratamiento" /> 
        </p>
    </div>
       
      <footer>
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <p>Copyright &copy; Clinica Ricardo Palma 2017</p>
                </div>
            </div>
        </div>
    </footer>
           </form>
</body>
</html>
