using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Utils.MySQLInterface
{
    public class MySQLConnector
    {
        private string server;
        private string uid;
        private string pwd;
        private string database;

        public MySQLConnector(string mySQLConnectionFilePath)
        {
            if (!File.Exists(mySQLConnectionFilePath)) { throw new Exception("File does not exist"); }

            string fileExtension = Path.GetExtension(mySQLConnectionFilePath);
            if (fileExtension != ".xml") { throw new Exception("File format is not XML"); }

            XDocument mySQLConnectionDoc = XDocument.Load(mySQLConnectionFilePath);
            var connection = mySQLConnectionDoc.Elements().First();
            if (mySQLConnectionDoc.Elements().Count() != 1 ||
                connection.Name.ToString() != "mySQLConnection")
            {
                throw new Exception("Wrong XML Document Format");
            }

            var elements = connection.Elements().ToList();
            if (elements.Count != 4 ||
                elements[0].Name.ToString() != "server" ||
                elements[1].Name.ToString() != "uid" ||
                elements[2].Name.ToString() != "pwd" ||
                elements[3].Name.ToString() != "database")
            {
                throw new Exception("Wrong XML Document Format");
            }

            this.server = elements[0].Value;
            this.uid = elements[1].Value;
            this.pwd = elements[2].Value;
            this.database = elements[3].Value;
        }

        public async Task<MySqlConnection> CreateConnection()
        {
            string conString = $"server={server};uid={uid};pwd={pwd};database={database};";
            MySqlConnection connection = new MySqlConnection(conString);
            
            try { await connection.OpenAsync(); }
            catch (Exception e)
            {
                if (e is InvalidOperationException) { throw new Exception("Invalid connection parameters"); }
                if (e is MySqlException) { throw new Exception($"MySql Error\nCode : {((MySqlException)e).Number}"); }
            }

            return connection;
        }
    }
}
