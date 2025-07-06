using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using Utils.DataFormats;
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
        public async Task DeleteRow_AdminTable_OneChange()
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
        public async Task DeleteRow_UserTable_OneChange()
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
        public async Task DeleteRow_ProductTable_OneChange()
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

        [TestMethod]
        public async Task InsertRow_AdminTable_OneChange()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);
            var account = new Account(100, "Test", "www.test@email.com", "test_pswd", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            int affectedRows = await parser.InsertRow(SqlTable.AdminInfo, account);

            // Assert
            if (affectedRows != 1) Assert.Fail();
        }

        [TestMethod]
        public async Task InsertRow_UserTable_OneChange()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);
            var account = new Account(100, "Test", "www.test@email.com", "test_pswd", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            int affectedRows = await parser.InsertRow(SqlTable.UserInfo, account);

            // Assert
            if (affectedRows != 1) Assert.Fail();
        }

        [TestMethod]
        public async Task InsertRow_ProductTable_OneChange()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);
            var product = new Product(100, "Test", "Test.INC", 99.99f, 10, "Electronics", "Test Description.");

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            int affectedRows = await parser.InsertRow(product);

            // Assert
            if (affectedRows != 1) Assert.Fail();
        }

        [TestMethod]
        public async Task UpdateRow_AdminTable_OneChange()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);
            var account = new Account(1, "Admin1Update", "www.admin1update@email.com", "admin1_update_pswd", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            int affectedRows = await parser.UpdateRow(SqlTable.AdminInfo, account);

            // Assert
            if (affectedRows != 1) Assert.Fail();
        }

        [TestMethod]
        public async Task UpdateRow_UserTable_OneChange()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);
            var account = new Account(1, "User1Update", "www.user1update@email.com", "user1_update_pswd", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            int affectedRows = await parser.UpdateRow(SqlTable.UserInfo, account);

            // Assert
            if (affectedRows != 1) Assert.Fail();
        }

        [TestMethod]
        public async Task UpdateRow_ProductTable_OneChange()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);
            var product = new Product(201, "Update", "Update.INC", 0.99f, 10, "Electronics", "Update Test.");

            // Act
            var parser = new MySQLParser(connector);
            await parser.ConnectAsync();
            int affectedRows = await parser.UpdateRow(product);

            // Assert
            if (affectedRows != 1) Assert.Fail();
        }
    }
}