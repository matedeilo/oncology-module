<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerarHojaPreparacionPage.aspx.cs" Inherits="SistemaOncologia.GenerarHojaPreparacionPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">
<link href="css/bootstrap.min.css" rel="stylesheet" media="screen">


    <title>Generacion de hoja de Preparacion</title>
</head>
<body>
    <div class="jumbotron">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Buscar Paciente:"></asp:Label>
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="DNI Paciente:"></asp:Label>
        <asp:TextBox ID="txtDniPaciente" runat="server"></asp:TextBox>

        <asp:Button ID="btnBuscarPaciente" runat="server" OnClick="btnBuscarPaciente_Click" Text="Buscar" style="height: 26px" />
        <br />
        <br />
        <asp:Label ID="lblPaciente" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="grdPaciente" runat="server" CellPadding="6"  
     CssClass= "table table-striped table-bordered table-condensed">        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Peso Paciente: "></asp:Label>
&nbsp;<asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Estado Paciente:"></asp:Label>
        <asp:TextBox ID="txtEstadoPaciente" runat="server" style="margin-left: 47px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnGenerar" runat="server" Text="Generar " OnClick="btnGenerar_Click" />
        <br />
        <br />
        <asp:Label ID="lblDosisOptimizada" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="grdHojaPreparacion" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>

    </div>
</body>
</html>
