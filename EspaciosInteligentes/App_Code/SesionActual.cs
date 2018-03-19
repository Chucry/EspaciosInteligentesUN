/// <summary>
/// Summary description for SesionActual
/// </summary>
public class SesionActual
{
    public SesionActual()
    {
        
    }

    public int IdUsuario { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public bool EsEmpleado { get; set; }

    public void CerrarSesion()
    {
        IdUsuario = 0;
        Nombre = null;
        Apellido = null;
        EsEmpleado = false;
    }
}