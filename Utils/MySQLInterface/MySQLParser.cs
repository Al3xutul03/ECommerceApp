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
        
        public SqlTable SqlTable { get { return sqlTable; } set { sqlTable = value; } }
        private SqlTable sqlTable;

        private IEnumerable<SqlColumn> sortColumns;
        private IEnumerable<SqlColumn> selectColumns;
        private SortType sortType;


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

        public MySQLParser(SqlTable sqlTable)
        {
            
            this.sqlTable = sqlTable;
        }

        public async Task ConnectAsync(MySQLConnector connector)
        {
            this.connection = await connector.CreateConnection();
        }

        public void Select(IEnumerable<SqlColumn> columns) { this.selectColumns = columns; }

        public void SortBy(IEnumerable<SqlColumn> columns, SortType sortType)
        {
            this.sortColumns = columns;
            this.sortType = sortType;
        }

        public async Task<DataTable> GetTable()
        {
            string commandString = BuildCommandString();
            MySqlCommand command = new MySqlCommand(commandString, connection);

            MySqlDataReader dr = await command.ExecuteReaderAsync(CommandBehavior.Default);
            DataTable dt = new DataTable();
            dt.Load(dr);

            return dt;
        }

        private string BuildCommandString()
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
            if (sortColumns != null && sortColumns.Count() > 0)
            {
                commandString += "ORDER BY ";
                var enumerator = sortColumns.GetEnumerator();
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
