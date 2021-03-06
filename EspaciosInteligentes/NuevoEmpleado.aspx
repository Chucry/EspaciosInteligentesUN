﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NuevoEmpleado.aspx.cs" Inherits="NuevoEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="Server">
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
        <br />
        <div class="container">
            <div class="col-lg-8 col-md-10 mx-auto">
                <div class="row">
                    <h4>Regístrate como Empleado</h4>

                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style2">Nombre:</td>
                            <td>
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Apellidos:</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Fecha de Nacimiento:</td>
                            <td>
                                <asp:TextBox ID="txtBirthDate" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Teléfono:</td>
                            <td>
                                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Celular:</td>
                            <td>
                                <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Departamento:</td>
                            <td>
                                <asp:DropDownList ID="ddlDepartment" runat="server" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Rol:</td>
                            <td>
                                <asp:DropDownList ID="ddlRole" runat="server" CssClass="form-control"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Salario:</td>
                            <td>
                                <asp:TextBox ID="txtSalary" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Dirección:</td>
                            <td>
                                <asp:TextBox ID="txtAddress1" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Colonia:</td>
                            <td>
                                <asp:TextBox ID="txtAddress2" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">NSS:</td>
                            <td>
                                <asp:TextBox ID="txtNSS" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">CURP:</td>
                            <td>
                                <asp:TextBox ID="txtCURP" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">CLABE:</td>
                            <td>
                                <asp:TextBox ID="txtCLABE" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                            </td>
                            <td>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Correo Electrónico:</td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Contraseña:</td>
                            <td>
                                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" Width="300px"></asp:TextBox>
                            </td>
                        </tr>

                    </table>
                </div>
            </div>
        </div>
        <br />
        <div class="container">
            <div class="row">
                <div>
                    <asp:LinkButton ID="btnRegistrarEmpleado" CssClass="btn btn-primary" runat="server" Width="570" OnClick="btnRegistrarEmpleado_Click">Registrar Empleado</asp:LinkButton>
                </div>
                <div>
                    <asp:LinkButton ID="btnCancelar" CssClass="btn btn-info" runat="server" Width="570px" OnClick="btnCancelar_Click">Cancelar</asp:LinkButton>
                </div>
            </div>
        </div>
    </form>
    <script src="js/nuevoEmpleado.js"></script>
</asp:Content>

