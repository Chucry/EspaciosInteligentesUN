using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        try
        {
            var context = new PooContext();

            var resultado = context.Login(txtUser.Text, txtPass.Text);
            if (resultado.IdUsuario != 0)
            {
                Session["usuario"] = resultado;
                Response.Redirect("verificar.aspx", false);
            }
            else
            {
                lblError.Text = "Error en el inicio de sesión";
            }
        }
        catch(Exception exe)
        {
            Console.WriteLine(exe);
            throw;
        }
    }
}