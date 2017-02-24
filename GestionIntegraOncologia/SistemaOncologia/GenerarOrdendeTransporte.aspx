<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerarOrdendeTransporte.aspx.cs" Inherits="SistemaOncologia.Generar_Orden_de_Transporte" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="grdEmpresaTransporte" runat="server" OnRowCommand="grdEmpresaTransporte_RowCommand">
            <Columns>
                <asp:CommandField HeaderText="Select" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="lblcomentario" runat="server" Text="Comentario" Visible="False"></asp:Label>
        <br />
        <asp:TextBox ID="txtSustento" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnContenedores" runat="server" OnClick="btnContenedores_Click" Text="Añadir Contenedores" />
        <br />
        <br />
        <asp:GridView ID="grdContenedores" runat="server">
            <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chkCtrl" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnGenerarOrden" runat="server" Text="Generar Orden de Transporte" OnClick="btnGenerarOrden_Click" />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="grdOrdenTransporte" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
