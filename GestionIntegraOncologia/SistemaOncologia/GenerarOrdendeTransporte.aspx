<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerarOrdendeTransporte.aspx.cs" Inherits="SistemaOncologia.Generar_Orden_de_Transporte" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Generar orden de transporte</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
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
            <li><a href="../GenerarHojaPreparacionPage.aspx">Hoja de preparacion</a></li>
            <li class="active"><a href="#about">Orden de transporte</a></li>
          </ul>
        </div>
      </div>
    </nav>
    <div class="container">  
    <form id="form1" runat="server" style="margin:34px 20px ; border:black 2px solid">
    <div class="jumbotron">
        <div class="row">
          <h2>Ranking de empresas de transporte</h2>
        </div>
    
        <asp:GridView ID="grdEmpresaTransporte" runat="server" OnRowCommand="grdEmpresaTransporte_RowCommand" CellPadding="5"  
            CssClass= "table table-striped table-bordered table-condensed">
            <Columns>
                <asp:CommandField HeaderText="Select" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="lblcomentario" runat="server" Text="Comentario" Visible="False" ></asp:Label>
        <br />
        <asp:TextBox ID="txtSustento" runat="server" Visible="False" required=''></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnContenedores" runat="server" OnClick="btnContenedores_Click" 
            Text="Añadir Contenedores" Cssclass="btn btn-info" BorderStyle="Double" />
        <br />
        <br />
        <asp:GridView ID="grdContenedores" runat="server" CellPadding="5"  
            CssClass= "table table-striped table-bordered table-condensed">
            <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chkCtrl" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnGenerarOrden" runat="server" Text="Generar Orden de Transporte" 
            OnClick="btnGenerarOrden_Click" Cssclass="btn btn-info" BorderStyle="Double" />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="grdOrdenTransporte" runat="server" CellPadding="5"  
            CssClass= "table table-striped table-bordered table-condensed">
        </asp:GridView>
        <br />
        <br />
        <br />
    
    </div>
    </form>
    </div>
</body>
</html>
