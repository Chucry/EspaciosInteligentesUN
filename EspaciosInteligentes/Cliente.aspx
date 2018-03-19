<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cliente.aspx.cs" Inherits="Cliente" %>

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
                    <%= Manager.RegistroHtml %>
                    <%= Manager.IniciarSesionHtml %>
                    <%= Manager.SaludoHtml %>
                    <%= Manager.CerrarSesionHtml %>
                </ul>
            </div>
        </div>
    </nav>

    <header class="masthead" style="background-image: url('img/monitores.png')">
        <div class="overlay"></div>
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-md-10 mx-auto">
                    <div class="page-heading">
                        <h1>Iniciar Sesion</h1>
                        <span class="subheading">Have questions? I have answers.</span>
                    </div>
                </div>
            </div>
        </div>
    </header>
</asp:Content>

