using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SessionManager
/// </summary>
public class SessionManager
{
    public IHtmlString IniciarSesionHtml { get; set; }
    public IHtmlString CerrarSesionHtml { get; set; }
    public IHtmlString SaludoHtml { get; set; }
    public IHtmlString RegistroHtml { get; set; }

    public SesionActual Sesion { get; set; }

    public SessionManager(SesionActual sesion)
    {
        Sesion = sesion;
        if (sesion.IdUsuario != 0)
        {
            SaludoHtml = Saludo();
            CerrarSesionHtml = CierreDeSesion();
        }
        else
        {
            RegistroHtml = Registrarme();
            IniciarSesionHtml = InicioDeSesion();
        }
    }

    public IHtmlString Saludo()
    {
        string html;
        if (Sesion.EsEmpleado)
            html = $"<li class='nav-item'><a class='nav-link' href='Empleado.aspx'>Hola {Sesion.Nombre}!</a></li>";
        else
            html = $"<li class='nav-item'><a class='nav-link' href='Cliente.aspx'>Hola {Sesion.Nombre}!</a></li>";

        return new HtmlString(html);
    }

    public IHtmlString InicioDeSesion()
    {
        var html = "<li class='nav-item'><a class='nav-link' href='Login.aspx'>Iniciar Sesión</a></li>";
        return new HtmlString(html);
    }

    public IHtmlString CierreDeSesion()
    {
        var html = "<li class='nav-item'><a class='nav-link' href='CerrarSesion.aspx'>Cerrar Sesión</a></li>";
        return new HtmlString(html);
    }

    public IHtmlString Registrarme()
    {
        var html = "<li class='nav-item'><a class='nav-link' href='NuevoRegistro.aspx'>Registrarme</a></li>";
        return new HtmlString(html);
    }
}