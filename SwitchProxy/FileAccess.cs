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

        public static void createFile(String filename)
        {

        }

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
    }
}
