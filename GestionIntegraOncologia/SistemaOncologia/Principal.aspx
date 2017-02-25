﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="SistemaOncologia.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Generacion de hoja de Preparacion</title>
</head>
<body>
    <div class="jumbotron">
        <h1>Sistema Integral Oncologico Clinica Ricardo Palma</h1>
    </div>
    
    <div class="container">
        <div class="page-header">
            <h1>Opciones</h1>
        </div>
        <p>
            <asp:Button Cssclass="btn btn-info" BorderStyle="Double" ID="btnBuscarPaciente" runat="server" OnClick="btnBuscarPaciente_Click" Text="Generar Hoja de Preparacion"  />

            <asp:Button ID="btnGenerarOrdenTransporte" runat="server" OnClick="btnGenerarOrdenTransporte_Click" Text="Generar Orden de Transporte" />
        </p>
    </div>
    <div class="jumbotron" style="margin-left:60px"  >
        <div class="">
            <form id="form1" runat="server">
            <h2 class="text-left">&nbsp;</h2>
        </div>
    
        <div class="form-group">
            <div class="row">
            </div>
        </div>
        <div class="form-group">
            <div class="row">
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
</body>
</html>
