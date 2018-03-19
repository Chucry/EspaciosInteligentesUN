using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SaveEmployeeResponse
/// </summary>
public class SaveEmployeeResponse
{
    public bool Success { get; set; }
    public int IdEmployee { get; set; }
    public string ErrorMessage { get; set; }
}