using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace DataAccess
{
    public static class DbManager
    {
        private static Dictionary<string, string> providers = new Dictionary<string, string>()
        {
            { ".accdb", "Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=kadiwaarchive" },
            { ".mdb" , "Microsoft.Jet.OLEDB.4.0" }
        };

        public static string BuildConnectionString(this string databaseName)
        {
            OleDbConnectionStringBuilder Builder = new OleDbConnectionStringBuilder
            {
                Provider = providers[Path.GetExtension(databaseName).ToLower()],
                DataSource = databaseName,
                ["Jet OLEDB:Database Password"] = "kadiwaarchive"
            };

            return Builder.ConnectionString;
        }

    }
}
