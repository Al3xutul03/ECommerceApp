using MySql.Data.MySqlClient;
using Utils.MySQLInterface;

namespace ECommerceApp.UnitTests
{
    [TestClass]
    public sealed class MySQLConnectorTests
    {
        [TestMethod]
        public void Constructor_ConnectionExistsAndHasValidFormat_NoExceptions()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Constructor_FilePathIsWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = @"erwftdsrfd\MySQL_connection.xml";
            bool success = false;

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                success = true;
            }
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Constructor_FileExtentionIsWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = "MySQL_connection.png";
            bool success = false;

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                success = true;
            }
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Constructor_FileFormatIsWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = "MySQL_connection_wrong_format1.xml";
            bool success = false;

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                success = true;
            }
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Constructor_ConnectionFormatIsWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = "MySQL_connection_wrong_format2.xml";
            bool success = false;

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                success = true;
            }
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Constructor_ConnectionChildNamesAreWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = "MySQL_connection_wrong_format3.xml";
            bool success = false;

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                success = true;
            }
            Assert.IsTrue(success);
        }
    }
}
