using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApi.DBoperate
{
    public class Connection
    {
        private static Configuration cfg = null;

        public static Configuration getConfiguration()
        {
            if (cfg == null)
            {
                cfg = new Configuration();

                cfg.SetProperty("connection.connection_string", "UID=" + "sa" + ";PWD=" + "iti@240" + ";Database=" + "ITILABTEST" + ";server=" + "115.24.161.31");
                cfg.AddAssembly("ClassLibrary");
            }
            return cfg;
        }

        private static SqlConnection connection = null;

        public static SqlConnection getSqlConnection()
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
               
                connection = new SqlConnection("UID=" + "sa" + ";PWD=" + "iti@240" + ";Database=" + "itilabtest" + ";server=" + "115.24.161.31");
            }
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    throw;
                }
            }
            return connection;
        }


    }
}