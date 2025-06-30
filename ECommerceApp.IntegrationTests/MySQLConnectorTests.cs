using MySql.Data.MySqlClient;
using Utils.MySQLInterface;

namespace ECommerceAppIntegrationTests
{
    [TestClass]
    public class MySQLConnectorTests
    {
        [TestMethod]
        public async Task CreateConnection_CreatedSuccessfullty_NoExceptions()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);
            MySqlConnection connection;

            // Act
            try { connection = await connector.CreateConnection(); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail();
            }
        }
    }
}
