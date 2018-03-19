using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubClases
{
    public class SaveClientResponse
    {
        public bool Success { get; set; }
        public int IdClient { get; set; }
        public string ErrorMessage { get; set; }
    }
}