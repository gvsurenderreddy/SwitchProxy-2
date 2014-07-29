using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace SwitchProxy
{
    public class FileAccess
    {

        /// <summary>
        /// Saves a copy of the ProxyTable in the application settings
        /// </summary>
        /// <param name="proxyTable">DataTable to save</param>
        public static void saveConfig(DataTable proxyTable)
        {
            DataTable copyTable = proxyTable.Copy();
            SwitchProxy.Properties.Settings.Default.ProxyTable = null;
            SwitchProxy.Properties.Settings.Default.ProxyTable = copyTable;
            SwitchProxy.Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Returns the previously saved DataTable
        /// </summary>
        /// <returns>Saved DataTable</returns>
        public static DataTable loadConfig()
        {
            SwitchProxy.Properties.Settings.Default.Reload();
            DataTable savedTable = SwitchProxy.Properties.Settings.Default.ProxyTable;
            return savedTable;
        }

        /// <summary>
        /// Checks, if there is an existing, previously saved DataTable
        /// </summary>
        /// <returns>True if exists, false if not</returns>
        public static bool configExists()
        {
            DataTable savedTable = loadConfig();
            if (savedTable == null || savedTable.Rows.Count == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
