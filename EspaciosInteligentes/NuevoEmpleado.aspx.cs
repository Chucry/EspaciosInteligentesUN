using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NuevoEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LlenarDepartamentos();
            LlenarRoles();
        }
    }

    protected void btnRegistrarEmpleado_Click(object sender, EventArgs e)
    {
        var context = new PooContext();

        var name = txtName.Text.Trim();
        var lastName = txtLastName.Text.Trim();
        var email = txtEmail.Text.Trim();
        var password = txtPassword.Text.Trim();
        var phone = txtPhone.Text.Trim();
        var birthDate = txtBirthDate.Text.Trim();
        var mobile = txtMobile.Text.Trim();
        var department = ddlDepartment.SelectedItem.Text;
        var role = ddlRole.SelectedItem.Text;
        var salary = Convert.ToSingle(txtSalary.Text.Trim());
        var address1 = txtAddress1.Text.Trim();
        var address2 = txtAddress2.Text.Trim();
        var nss = txtNSS.Text.Trim();
        var curp = txtCURP.Text.Trim();
        var clabe = txtCLABE.Text.Trim();

        var response = context.SaveEmployee(name, lastName, email, password, phone, birthDate, mobile, department, role, salary, address1, address2, nss, curp, clabe);

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

    protected void LlenarDepartamentos()
    {
        ddlDepartment.Items.Add(new ListItem("Producción", "1"));
        ddlDepartment.Items.Add(new ListItem("Recursos Humanos", "2"));
    }

    protected void LlenarRoles()
    {
        ddlRole.Items.Clear();

        switch (ddlDepartment.SelectedItem.Text)
        {
            case "Producción":
                ddlRole.Items.Add(new ListItem("Instalador", "1"));
                ddlRole.Items.Add(new ListItem("Servicio al Cliente", "2"));
                ddlRole.Items.Add(new ListItem("Desarrollador", "3"));
                break;
            case "Recursos Humanos":
                ddlRole.Items.Add(new ListItem("Reclutador", "4"));
                break;
        }
    }

    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        LlenarRoles();
    }
}