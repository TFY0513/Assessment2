using Assessment2.Models;
using System.Collections.Generic;
using Assessment2.DBContext;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Xml;
using System.IO;

namespace Assessment2.Misc
{
    public class Misc
    {
        private readonly static string ConfigurationFilePath = @"C:\Config\Demo.xml";
        public static SqlConnection GetConnection()
        {
            string localConnectionString = "";
            if (File.Exists(ConfigurationFilePath))
            {
                XmlDocument configDoc = new XmlDocument();
                configDoc.Load(ConfigurationFilePath);
                XmlNode databaseNode = configDoc.SelectSingleNode("/Configurations/DatabaseList/Database[Name='Demo']");
                if (databaseNode != null)
                {
                    localConnectionString = databaseNode.SelectSingleNode("ConnectionString").InnerText;
                }
            }
            return new SqlConnection(localConnectionString);
        }
    }
}
