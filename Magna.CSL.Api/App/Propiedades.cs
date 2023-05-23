using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Magna.CSL.Api.App
{
    public class Propiedades
    {
        public static string GetConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString; }
        }

        public static System.Data.SqlClient.SqlConnectionStringBuilder SqlConnectionString
        {
            get
            {
                return new System.Data.SqlClient.SqlConnectionStringBuilder(GetConnectionString);
            }
        }
    }
}