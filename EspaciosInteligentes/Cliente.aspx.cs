using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cliente : System.Web.UI.Page
{
    public SessionManager Manager { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        var sesion = Session["usuario"] != null ? (SesionActual)Session["usuario"] : new SesionActual();

        Manager = new SessionManager(sesion);
    }
}