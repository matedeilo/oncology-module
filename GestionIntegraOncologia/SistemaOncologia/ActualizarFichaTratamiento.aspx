<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActualizarFichaTratamiento.aspx.cs" Inherits="SistemaOncologia.ActualizarFichaTratamiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Actualizar Ficha de tratamiento</title>
    
</head>
<body>
    <form id="form1" runat="server">
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
            <li class="active"><a href="../GenerarOrdendeTransporte.aspx">Orden de transporte</a></li>
            <li><a href="../ActualizarPreparacionMezclaCitostatica.aspx">Actualizar preparacion de mezcal Citostática</a></li>
          </ul>
        </div>
      </div>
    </nav>
    </form>
</body>
</html>
