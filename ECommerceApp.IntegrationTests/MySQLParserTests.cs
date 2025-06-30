using MySql.Data.MySqlClient;
using System.Data;
using Utils.MySQLInterface;

namespace ECommerceApp.IntegrationTests
{
    [TestClass]
    public sealed class MySQLParserTests
    {
        [TestMethod]
        public async Task GetTable_AdminTableWithNoFilter_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(SqlTable.AdminInfo);
            await parser.ConnectAsync(connector);
            DataTable dt = await parser.GetTable();

            // Assert
            if (dt.TableName != "admin_info") Assert.Fail();
        }

        [TestMethod]
        public async Task GetTable_UserTableWithNoFilter_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(SqlTable.UserInfo);
            await parser.ConnectAsync(connector);
            DataTable dt = await parser.GetTable();

            // Assert
            if (dt.TableName != "user_info") Assert.Fail();
        }

        [TestMethod]
        public async Task GetTable_AdminTableWithFilters_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(SqlTable.AdminInfo);
            await parser.ConnectAsync(connector);
            parser.Select(new List<SqlColumn> { SqlColumn.Username, SqlColumn.ID });
            parser.SortBy(new List<SqlColumn> { SqlColumn.Username }, SortType.Descending);
            DataTable dt = await parser.GetTable();

            // Assert
            if (dt.TableName != "admin_info") Assert.Fail();
        }

        [TestMethod]
        public async Task GetTable_UserTableWithFilters_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(SqlTable.UserInfo);
            await parser.ConnectAsync(connector);
            parser.Select(new List<SqlColumn> { SqlColumn.Username });
            parser.SortBy(new List<SqlColumn> { SqlColumn.ID }, SortType.Descending);
            DataTable dt = await parser.GetTable();

            // Assert
            if (dt.TableName != "user_info") Assert.Fail();
        }
    }
}