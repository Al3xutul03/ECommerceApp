using NUnit.Framework.Internal.Execution;
using System.Diagnostics;
using Utils.MySQLInterface;

namespace ECommerceApp.UnitTests
{
    [TestFixture]
    public class MySQLConnectorTests
    {
        [Test]
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
            Assert.Pass();
        }

        [Test]
        public void Constructor_FilePathIsWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = @"erwftdsrfd\MySQL_connection.xml";

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Constructor_FileExtentionIsWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = "MySQL_connection.png";

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Constructor_FileFormatIsWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = "MySQL_connection_wrong_format1.xml";

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Constructor_ConnectionFormatIsWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = "MySQL_connection_wrong_format2.xml";

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Constructor_ConnectionChildNamesAreWrong_ThrowException()
        {
            // Arrange
            string connectionFilePath = "MySQL_connection_wrong_format3.xml";

            // Act
            try { MySQLConnector mySQLConnector = new MySQLConnector(connectionFilePath); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}