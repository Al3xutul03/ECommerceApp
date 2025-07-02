using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.MySQLInterface
{
    public class MySQLParser
    {
        private MySqlConnection connection;
        private MySQLConnector connector;

        private static Dictionary<SqlTable, string> tableStrings = new Dictionary<SqlTable, string>
        {
            { SqlTable.AdminInfo, "admin_info" },
            { SqlTable.UserInfo, "user_info" }
        };

        private static Dictionary<SqlColumn, string> columnStrings = new Dictionary<SqlColumn, string>
        {
            { SqlColumn.ID, "id" },
            { SqlColumn.Username, "username" },
        };

        private static Dictionary<SortType, string> sortStrings = new Dictionary<SortType, string>
        {
            { SortType.Ascending, "ASC" },
            { SortType.Descending, "DESC" }
        };

        public MySQLParser(MySQLConnector connector)
        {
            this.connector = connector;
        }

        public async Task ConnectAsync()
        {
            this.connection = await connector.CreateConnection();
        }

        public async Task<DataTable> GetTable(SqlTable sqlTable,
            IEnumerable<SqlColumn> selectColumns, IEnumerable<SqlColumn> sortbyColumns, SortType sortType)
        {
            string commandString = BuildCommandString(sqlTable, selectColumns, sortbyColumns, sortType);
            MySqlCommand command = new MySqlCommand(commandString, connection);

            MySqlDataReader dr = await command.ExecuteReaderAsync(CommandBehavior.Default);
            DataTable dt = new DataTable();
            dt.Load(dr);

            return dt;
        }

        public async Task<DataTable> GetTable(SqlTable sqlTable)
        {
            string commandString = BuildCommandString(sqlTable, null, null, SortType.None);
            MySqlCommand command = new MySqlCommand(commandString, connection);

            MySqlDataReader dr = await command.ExecuteReaderAsync(CommandBehavior.Default);
            DataTable dt = new DataTable();
            dt.Load(dr);

            return dt;
        }

        private string BuildCommandString(SqlTable sqlTable,
            IEnumerable<SqlColumn> selectColumns, IEnumerable<SqlColumn> sortbyColumns, SortType sortType)
        {
            string commandString = "SELECT ";
            if (selectColumns == null || selectColumns.Count() == 0) { commandString += '*'; }
            else
            {
                var enumerator = selectColumns.GetEnumerator();
                enumerator.MoveNext();
                commandString += columnStrings[enumerator.Current];
                while (enumerator.MoveNext()) { commandString += $", {columnStrings[enumerator.Current]}"; }
            }

            commandString += $" FROM {tableStrings[sqlTable]} ";
            if (sortbyColumns != null && sortbyColumns.Count() > 0)
            {
                commandString += "ORDER BY ";
                var enumerator = sortbyColumns.GetEnumerator();
                enumerator.MoveNext();
                commandString += columnStrings[enumerator.Current];
                while (enumerator.MoveNext()) { commandString += $", {columnStrings[enumerator.Current]}"; }
            }
            commandString += ';';

            return commandString;
        }
    }

    public enum SqlTable { AdminInfo, UserInfo }

    public enum SqlColumn { ID, Username }

    public enum SortType { None, Ascending, Descending }
}
