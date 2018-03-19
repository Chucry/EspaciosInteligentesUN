using System;

public partial class Verificar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var sesion = Session["usuario"] != null ? (SesionActual) Session["usuario"] : new SesionActual();
        
        if (sesion.IdUsuario != 0)
        {
            Response.Redirect(sesion.EsEmpleado ? "Empleado.aspx" : "Cliente.aspx");
        }
    }
}