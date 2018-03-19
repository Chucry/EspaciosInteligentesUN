using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NuevoCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var context = new PooContext();
            ddlCity.DataSource = context.GetCities().Tables[0];
            ddlCity.DataValueField = "Id";
            ddlCity.DataTextField = "Name";
            ddlCity.DataBind();
        }
    }

    protected void btnRegistrarCliente_Click(object sender, EventArgs e)
    {
        var context = new PooContext();
        var name = txtName.Text.Trim();
        var lastName = txtLastName.Text.Trim();
        var email = txtEmail.Text.Trim();
        var password = txtPassword.Text.Trim();
        var birthDate = txtBirthDate.Text.Trim();
        var phone = txtContactNumber.Text.Trim();
        var cityId = Convert.ToInt32(ddlCity.SelectedItem.Value);

        var response = context.SaveClient(name, lastName, email, password, birthDate, phone, cityId);

        if (!response.Success && response.ErrorMessage != null)
            ClientScript.RegisterStartupScript(this.GetType(), "popup", $"alert('{response.ErrorMessage}')", true);
        else if (!response.Success && response.ErrorMessage == null)
            ClientScript.RegisterStartupScript(this.GetType(), "popup", "alert('Ocurrió un error, por favor revisa la información e intenta de nuevo.')", true);
        else
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Registro completado con éxito. Ahora puedes iniciar sesión!');window.location ='Login.aspx';", true);
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("NuevoCliente.aspx");
    }

    protected void btnNuevoCliente_Click(object sender, EventArgs e)
    {
        Response.Redirect("NuevoCliente.aspx");
    }

    protected void btnNuevoEmpleado_Click(object sender, EventArgs e)
    {
        Response.Redirect("NuevoEmpleado.aspx");
    }
}