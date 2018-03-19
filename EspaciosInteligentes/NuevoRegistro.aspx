<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NuevoRegistro.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="Server">
    <nav class="navbar navbar-expand-lg navbar-light fixed-top" id="mainNav">
        <div class="container">
            <a class="navbar-brand" href="Index.aspx">Espacios Inteligentes</a>
            <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                Menu
                <i class="fa fa-bars"></i>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="Index.aspx">Volver</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <form id="form2" runat="server">

        <header class="masthead" style="background-image: url('img/sign-up.jpg')">
            <div class="overlay"></div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-md-10 mx-auto">
                        <div class="page-heading">
                            <h1>Crea una cuenta</h1>
                            <span class="subheading">Selecciona el perfil adecuado y llena los datos solicitados</span>
                        </div>
                    </div>
                </div>
            </div>
        </header>

        <!-- Main Content -->
        <div class="container">
                <div class="row">
                    <div>
                        <asp:LinkButton ID="btnNuevoCliente" CssClass="btn btn-primary" runat="server" OnClick="btnNuevoCliente_Click" Width="570">Nuevo Cliente</asp:LinkButton>
                    </div>
                    <div>
                        <asp:LinkButton ID="btnNuevoEmpleado" CssClass="btn btn-info" runat="server" OnClick="btnNuevoEmpleado_Click" Width="570px">Nuevo Empleado</asp:LinkButton>
                    </div>
                </div>
        </div>
    </form>
</asp:Content>
