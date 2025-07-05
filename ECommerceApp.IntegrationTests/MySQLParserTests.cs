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
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            DataTable dt = await parser.GetTable(SqlTable.AdminInfo);

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
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            DataTable dt = await parser.GetTable(SqlTable.UserInfo);

            // Assert
            if (dt.TableName != "user_info") Assert.Fail();
        }

        [TestMethod]
        public async Task GetTable_ProductTableWithNoFilter_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            DataTable dt = await parser.GetTable(SqlTable.ProductInfo);

            // Assert
            if (dt.TableName != "product_info") Assert.Fail();
        }

        [TestMethod]
        public async Task GetTable_AdminTableWithFilters_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            DataTable dt = await parser.GetTable(SqlTable.AdminInfo,
                selectColumns: new List<SqlColumn> { SqlColumn.Username, SqlColumn.ID },
                sortbyColumns: new List<SqlColumn> { SqlColumn.Username },
                SortType.Descending);

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
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            DataTable dt = await parser.GetTable(SqlTable.UserInfo,
                selectColumns: new List<SqlColumn> { SqlColumn.Username },
                sortbyColumns: new List<SqlColumn> { SqlColumn.ID },
                SortType.Descending);

            // Assert
            if (dt.TableName != "user_info") Assert.Fail();
        }

        [TestMethod]
        public async Task GetTable_ProductTableWithFilters_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            DataTable dt = await parser.GetTable(SqlTable.ProductInfo,
                selectColumns: new List<SqlColumn> { SqlColumn.ProductName },
                sortbyColumns: new List<SqlColumn> { SqlColumn.ID },
                SortType.Ascending);

            // Assert
            if (dt.TableName != "product_info") Assert.Fail();
        }

        [TestMethod]
        public async Task DeleteRow_AdminTable_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            int affectedRows = await parser.DeleteRow(SqlTable.AdminInfo, 2);

            // Assert
            if (affectedRows != 1) Assert.Fail();
        }

        [TestMethod]
        public async Task DeleteRow_UserTable_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            int affectedRows = await parser.DeleteRow(SqlTable.UserInfo, 5);

            // Assert
            if (affectedRows != 1) Assert.Fail();
        }

        [TestMethod]
        public async Task DeleteRow_ProductTable_FullTable()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            int affectedRows = await parser.DeleteRow(SqlTable.ProductInfo, 226);

            // Assert
            if (affectedRows != 1) Assert.Fail();
        }
    }
}