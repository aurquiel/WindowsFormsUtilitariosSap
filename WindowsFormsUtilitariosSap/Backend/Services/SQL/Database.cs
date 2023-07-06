using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUtilitariosSap.Backend.Services.SQL
{
    public class Database
    {
        internal readonly int SQL_TIMEOUT_EXECUTION_COMMAND;

        public Database()
        {
            try
            {
                SQL_TIMEOUT_EXECUTION_COMMAND = Int32.Parse(ConfigurationManager.AppSettings["SQL_TIMEOUT"]);
            }   
            catch
            {
                SQL_TIMEOUT_EXECUTION_COMMAND = 600;
            }  
        }

        internal string GetSettingsConenction()
        {
            try
            {
                string setting = ConfigurationManager.ConnectionStrings["SAP"].ConnectionString;
                return setting;
            }
            catch
            {
                return string.Empty;
            }
        }

    }
}
