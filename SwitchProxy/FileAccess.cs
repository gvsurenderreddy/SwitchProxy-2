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
        private const String fileName = "config.xml";
        private const String fileScheme = "config_scheme.xsd";

        /// <summary>
        /// Saves a DataTable as XML file in a specified path
        /// </summary>
        /// <param name="proxyTable">DataTable to save</param>
        public static void saveConfig(DataTable proxyTable)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                File.Delete(fileScheme);
            }
            proxyTable.WriteXml(fileName);
            proxyTable.WriteXmlSchema(fileScheme);
        }

        /// <summary>
        /// Loads a DataTable from a previously saved XML file
        /// </summary>
        /// <returns>Saved DataTable</returns>
        public static DataTable loadConfig()
        {
            DataTable proxyTable = new DataTable();
            if (File.Exists(fileName))
            {
                proxyTable.ReadXmlSchema(fileScheme);
                proxyTable.ReadXml(fileName);
            }
            return proxyTable;
        }

        /// <summary>
        /// Checks, if the DataTable file exists
        /// </summary>
        /// <returns>True if exists, false if not exists</returns>
        public static bool configExists()
        {
            return (File.Exists(fileName));
        }
    }
}
