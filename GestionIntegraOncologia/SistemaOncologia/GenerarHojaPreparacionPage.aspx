<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerarHojaPreparacionPage.aspx.cs" Inherits="SistemaOncologia.GenerarHojaPreparacionPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Generacion de hoja de Preparacion</title>
</head>
<body>
    <nav class="navbar navbar-inverse navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="../principal.aspx">Ricardo Palma</a>
        </div>
        <div id="navbar" class="collapse navbar-collapse">
          <ul class="nav navbar-nav">
            <li class="active"><a href="#">Hoja de preparacion</a></li>
            <li><a href="../GenerarOrdendeTransporte.aspx">Orden de transporte</a></li>
            <li><a href="../ActualizarPreparacionMezclaCitostatica.aspx">Actualizar preparacion de mezcal Citostática</a></li>
          </ul>
        </div>
      </div>
    </nav>
   <form id="form2" runat="server">
    <div class="container">
  

          <div class="container">

                      <div class="form-group" style="margin-left:60px; margin-top:50px;">
       <div class="row">
            <div class="col-md-10" >
                <h1 style="">Generar Hoja de preparación</h1>
            </div>
        </div>
    </div>
    <div class="jumbotron" style="margin-left:60px; margin-top:50px;"  >
        <div class="">
            <h2 class="text-left"><asp:Label ID="Label1" runat="server" Text="Buscar Paciente:"></asp:Label></h2>
        </div>
    <div class="form-group">
       <div class="row">
            <div class="col-md-2" >
                <asp:Label ID="Label2" runat="server" Text="DNI Paciente:" style="font-size=13px"></asp:Label>
            </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtDniPaciente" runat="server" class="form-control input-lg" Width="160px" Height="7px" required='' type='number'></asp:TextBox>
        </div>
        <div class="col-md-7">
            <asp:Button runat="server"  Cssclass="btn btn-info" BorderStyle="Double" ID="btnBuscarPaciente" OnClick="btnBuscarPaciente_Click" Text="Buscar"  />
        </div>
           </div>
    </div>
    <div class="form-group">
        <div class="row">
            <div class="col-md-12" >
                <asp:Label ID="lblPaciente" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
        <asp:GridView ID="grdPaciente" runat="server" CellPadding="5"  
            CssClass= "table table-striped table-bordered table-condensed"></asp:GridView>
    <div class="form-group">
        <div class="row">
            <div class="col-md-2" >
                <asp:Label ID="Label3" runat="server" Text="Peso Paciente: "></asp:Label>
            </div>
            <div class="col-md-10" >
                <asp:TextBox ID="txtPeso" runat="server" class="form-control input-lg" Width="160px" Height="3px" ></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="row">
            <div class="col-md-2" >
                <asp:Label ID="Label4" runat="server" Text="Estado Paciente:"></asp:Label>
            </div>
            <div class="col-md-10" >
                <asp:DropDownList ID="ddlEstado" runat="server" CssClass AutoPostBack="True" Enabled="true" EnableViewState="False">
                    <asp:ListItem>Optimo</asp:ListItem>
                    <asp:ListItem>Muy Bueno</asp:ListItem>
                    <asp:ListItem>Bueno</asp:ListItem>
                    <asp:ListItem>Regular</asp:ListItem>
                </asp:DropDownList>
                <!--<asp:TextBox ID="txtEstadoPaciente" runat="server" class="form-control input-lg" Width="160px" Height="3px" ></asp:TextBox> -->
            </div>
        </div>
    </div>
    <div class="form-group">
        <asp:Button class="btn btn-info" ID="btnGenerar" runat="server" Text="Generar " OnClick="btnGenerar_Click" />
    </div>
        
        <asp:Label ID="lblDosisOptimizada" runat="server" Text=""></asp:Label>
       
        <asp:GridView ID="grdHojaPreparacion" runat="server" CellPadding="5"  
            CssClass= "table table-striped table-bordered table-condensed">
        </asp:GridView>
            </div>
        </div>

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
