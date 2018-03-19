using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using SubClases;

/// <summary>
/// Summary description for PooContext
/// </summary>
public class PooContext
{
    public PooContext()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private SqlConnection GetConnection()
    {
        try
        {
            var connectionString = ConfigurationManager.ConnectionStrings["POOContext"].ToString();
            var con = new SqlConnection(connectionString);
            return con;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataSet ExecuteQuery(string query)
    {
        try
        {
            var con = GetConnection();
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            var adapter = new SqlDataAdapter(cmd);
            var result = new DataSet();
            adapter.Fill(result);
            con.Close();
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public SesionActual Login(string userName, string password)
    {
        var sesion = new SesionActual();

            try
            {
                var clienteQuery =
                    $"SELECT Id, Name, Lastname FROM Clients WHERE Email = '{userName}' AND Password = '{password}'";

                var cliente = ExecuteQuery(clienteQuery);

                //para checar si está en la lista de clientes
                if (cliente.Tables[0].Rows.Count > 0)
                {
                    sesion.IdUsuario = (int)cliente.Tables[0].Rows[0][0];
                    sesion.Nombre = cliente.Tables[0].Rows[0][1].ToString();
                    sesion.Apellido = cliente.Tables[0].Rows[0][2].ToString();
                    sesion.EsEmpleado = false;

                    return sesion;
                }
                var empleadoQuery =
                        $"SELECT Id, Name, LastName FROM Employees WHERE Email = '{userName}' AND Password = '{password}'";

                var empleado = ExecuteQuery(empleadoQuery);

                //para checar si está en la lista de empleados
                if (empleado.Tables[0].Rows.Count > 0)
                {
                    sesion.IdUsuario = (int)empleado.Tables[0].Rows[0][0];
                    sesion.Nombre = empleado.Tables[0].Rows[0][1].ToString();
                    sesion.Apellido = empleado.Tables[0].Rows[0][2].ToString();
                    sesion.EsEmpleado = true;

                    return sesion;
                }

                return sesion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
    }

    public DataSet GetCities()
    {
        var query = "SELECT Id, Name FROM Cities";

        var result = ExecuteQuery(query);

        return result;
    }

    public SaveClientResponse SaveClient(string name, string lastName, string email, string password, string birthDate, string phone, int idCity)
    {
        try
        {
            var response = new SaveClientResponse();

            //Checar si existe el email en la base de datos y regresar un error en caso de ser así
            var selectQuery = $"SELECT * FROM Clients WHERE Email = '{email}'";

            var check = ExecuteQuery(selectQuery).Tables[0];

            if (check.Rows.Count > 0)
            {
                response.Success = false;
                response.ErrorMessage = "Esa dirección de email ya está en uso.";
            }
            else
            {
                var insertQuery = $"INSERT INTO Clients VALUES ('{name}', '{lastName}', '{email}', '{password}', '{birthDate}', {phone}, {idCity})";
                ExecuteQuery(insertQuery);

                check = ExecuteQuery(selectQuery).Tables[0];

                response.Success = true;
                response.IdClient = (int)check.Rows[0][0];
            }
            
            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public SaveEmployeeResponse SaveEmployee(string name, string lastName,
        string email, string password, string phone, string birthDate, string mobile, string department, string role,
        float salary, string address1, string address2, string nss, string curp, string clabe)
    {
        try
        {
            var response = new SaveEmployeeResponse();

            //Checar si existe el email en la base de datos y regresar un error en caso de ser así
            var selectQuery = $"SELECT * FROM Employees WHERE Email = '{email}'";

            var check = ExecuteQuery(selectQuery).Tables[0];

            if (check.Rows.Count > 0)
            {
                response.Success = false;
                response.ErrorMessage = "Esa dirección de email ya está en uso.";
            }
            else
            {
                var insertQuery = $"INSERT INTO Employees VALUES ('{name}', '{lastName}', '{birthDate}', '{email}', '{password}', {phone}, {mobile}, '{department}', " +
                                  $"'{role}', '{DateTime.Now.ToString("yyyy-MM-dd")}', NULL, {salary}, '{address1}', '{address2}', {nss}, '{curp}', '{clabe}')";
                var query = insertQuery;
                ExecuteQuery(insertQuery);

                check = ExecuteQuery(selectQuery).Tables[0];

                response.Success = true;
                response.IdEmployee = (int)check.Rows[0][0];
            }

            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}