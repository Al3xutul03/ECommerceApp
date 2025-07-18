﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Utils.DataFormats;

namespace Utils.MySQLInterface
{
    public class MySQLParser
    {
        private MySqlConnection connection;
        private MySQLConnector connector;

        private static Dictionary<SqlTable, string> tableStrings = new Dictionary<SqlTable, string>
        {
            { SqlTable.AdminInfo, "admin_info" },
            { SqlTable.UserInfo, "user_info" },
            { SqlTable.ProductInfo, "product_info" }
        };

        private static Dictionary<SqlColumn, string> columnStrings = new Dictionary<SqlColumn, string>
        {
            { SqlColumn.ID, "id" },
            { SqlColumn.Username, "username" },
            { SqlColumn.ProductName, "product_name" }
        };

        private static Dictionary<SortType, string> sortStrings = new Dictionary<SortType, string>
        {
            { SortType.Ascending, "ASC" },
            { SortType.Descending, "DESC" }
        };

        private static Dictionary<SqlTable, string> searchStrings = new Dictionary<SqlTable, string>
        {
            { SqlTable.AdminInfo, "username" },
            { SqlTable.UserInfo, "username"},
            { SqlTable.ProductInfo, "product_name" }
        };

        public MySQLParser(MySQLConnector connector)
        {
            this.connector = connector;
        }

        public async Task ConnectAsync()
        {
            this.connection = await connector.CreateConnection();
        }

        public async Task<DataTable> GetTable(SqlTable sqlTable, string searchString, string categoryString,
            IEnumerable<SqlColumn> selectColumns, IEnumerable<SqlColumn> sortbyColumns, SortType sortType)
        {
            string commandString = BuildSelectString(sqlTable, searchString, categoryString, selectColumns, sortbyColumns, sortType);
            MySqlCommand command = new MySqlCommand(commandString, connection);

            MySqlDataReader dr = await command.ExecuteReaderAsync(CommandBehavior.Default);
            DataTable dt = new DataTable();
            dt.Load(dr);

            return dt;
        }

        public async Task<DataTable> GetTable(SqlTable sqlTable)
        {
            string commandString = BuildSelectString(sqlTable, null, null, null, null, SortType.None);
            MySqlCommand command = new MySqlCommand(commandString, connection);

            MySqlDataReader dr = await command.ExecuteReaderAsync(CommandBehavior.Default);
            DataTable dt = new DataTable();
            dt.Load(dr);

            return dt;
        }

        public async Task<int> DeleteRow(SqlTable sqlTable, int id)
        {
            string commandString = BuildDeleteString(sqlTable, id);
            return await ExecuteCommand(commandString);
        }

        public async Task<int> InsertRow(SqlTable accountTable, Account newAccount)
        {
            newAccount.Id = await GetNextID(accountTable);

            string commandString = BuildInsertString(accountTable, newAccount);
            return await ExecuteCommand(commandString);
        }

        public async Task<int> InsertRow(Product newProduct)
        {
            newProduct.Id = await GetNextID(SqlTable.ProductInfo);

            string commandString = BuildInsertString(newProduct);
            return await ExecuteCommand(commandString);
        }

        public async Task<int> UpdateRow(SqlTable accountTable, Account account)
        {
            string commandString = BuildUpdateString(accountTable, account);
            return await ExecuteCommand(commandString);
        }

        public async Task<int> UpdateRow(Product product)
        {
            string commandString = BuildUpdateString(product);
            return await ExecuteCommand(commandString);
        }

        private async Task<int> ExecuteCommand(string commandString)
        {
            MySqlCommand command = new MySqlCommand(commandString, connection);

            int affectedRows = await command.ExecuteNonQueryAsync();
            return affectedRows;
        }

        private async Task<int> GetNextID(SqlTable sqlTable)
        {
            DataTable dt = await GetTable(sqlTable, null, null, null, new List<SqlColumn> { SqlColumn.ID }, SortType.Descending);
            return (int)dt.Rows[0][0] + 1;
        }

        private string BuildSelectString(SqlTable sqlTable, string searchString, string categoryString,
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

            string finalSearchString;
            if (searchString == null) finalSearchString = string.Empty;
            else finalSearchString = searchString;
            commandString += $"WHERE {searchStrings[sqlTable]} LIKE '%{searchString}%' ";

            if (categoryString != null && categoryString != string.Empty)
            {
                commandString += $"AND category = '{categoryString}' ";
            }

            if (sortbyColumns != null && sortbyColumns.Count() > 0 && sortType != SortType.None)
            {
                commandString += "ORDER BY ";
                var enumerator = sortbyColumns.GetEnumerator();
                enumerator.MoveNext();
                commandString += columnStrings[enumerator.Current];
                while (enumerator.MoveNext()) { commandString += $", {columnStrings[enumerator.Current]}"; }
                commandString += $" {sortStrings[sortType]}";
            }  
            commandString += ';';

            return commandString;
        }

        private string BuildDeleteString(SqlTable sqlTable, int id)
        {
            string commandString = $"DELETE FROM {tableStrings[sqlTable]} WHERE id = {id};";
            return commandString;
        }

        private string BuildInsertString(SqlTable sqlTable, Account newAccount)
        {
            string commandString = $"INSERT INTO {tableStrings[sqlTable]} (id, username, email, pswd, creation_date) VALUES " +
                $"({newAccount.Id}, '{newAccount.Username}', '{newAccount.Email}', '{newAccount.Password}', '{newAccount.CreationDate}');";
            return commandString;
        }

        private string BuildInsertString(Product newProduct)
        {
            string commandString = $"INSERT INTO {tableStrings[SqlTable.ProductInfo]} (id, product_name, producer, price, stock, category, product_description) VALUES " +
                $"({newProduct.Id}, '{newProduct.Name}', '{newProduct.Producer}', {newProduct.Price.ToString(CultureInfo.InvariantCulture)}, " +
                $"{newProduct.Stock}, '{newProduct.Category}', '{newProduct.Description}');";
            return commandString;
        }

        private string BuildUpdateString(SqlTable sqlTable, Account account)
        {
            string commandString = $"UPDATE {tableStrings[sqlTable]} SET " +
                $"username = '{account.Username}', email = '{account.Email}', pswd = '{account.Password}' " +
                $"WHERE id = {account.Id};";
            return commandString;
        }

        private string BuildUpdateString(Product product)
        {
            string commandString = $"UPDATE {tableStrings[SqlTable.ProductInfo]} SET " +
                $"product_name = '{product.Name}', producer = '{product.Producer}', price = {product.Price.ToString(CultureInfo.InvariantCulture)}, " +
                $"stock = {product.Stock}, category = '{product.Category}', product_description = '{product.Description}' " +
                $"WHERE id = {product.Id};";
            return commandString;
        }
    }

    public enum SqlTable { AdminInfo, UserInfo, ProductInfo }

    public enum SqlColumn { ID, Username, ProductName }

    public enum SortType { None, Ascending, Descending }
}
