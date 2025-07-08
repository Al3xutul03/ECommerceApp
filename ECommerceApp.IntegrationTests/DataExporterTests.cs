using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Utils.DataFormats;
using Utils.DataHandling;
using Utils.MySQLInterface;

namespace ECommerceApp.IntegrationTests
{
    [TestClass]
    public sealed class DataExporterTests
    {
        [TestMethod]
        public void ExportData_AdminTableToXML_FileCreated()
        {
            // Arrange
            var admins = new List<Object>
            {
                new Account(1, "Admin1", "www.admin1@email.com", "admin1_pswd", "0000-00-00"),
                new Account(2, "Admin2", "www.admin2@email.com", "admin2_pswd", "0000-00-00"),
                new Account(3, "Admin3", "www.admin3@email.com", "admin3_pswd", "0000-00-00"),
                new Account(4, "Admin4", "www.admin4@email.com", "admin4_pswd", "0000-00-00"),
            };
            var exporter = new DataExporter(typeof(Account), admins);

            // Act
            exporter.ExportData(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Admins.xml"), TransferType.XML, SqlTable.AdminInfo);

            // Assert
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Admins.xml"))) { Assert.Fail(); }
        }

        [TestMethod]
        public void ExportData_AdminTableToPDF_FileCreated()
        {
            // Arrange
            var admins = new List<Object>
            {
                new Account(1, "Admin1", "www.admin1@email.com", "admin1_pswd", "0000-00-00"),
                new Account(2, "Admin2", "www.admin2@email.com", "admin2_pswd", "0000-00-00"),
                new Account(3, "Admin3", "www.admin3@email.com", "admin3_pswd", "0000-00-00"),
                new Account(4, "Admin4", "www.admin4@email.com", "admin4_pswd", "0000-00-00"),
            };
            var exporter = new DataExporter(typeof(Account), admins);

            // Act
            exporter.ExportData(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Admins.pdf"), TransferType.PDF, SqlTable.AdminInfo);

            // Assert
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Admins.pdf"))) { Assert.Fail(); }
        }

        [TestMethod]
        public void ExportData_UserTableToXML_FileCreated()
        {
            // Arrange
            var users = new List<Object>
            {
                new Account(1, "User1", "www.user1@email.com", "user1_pswd", "0000-00-00"),
                new Account(2, "User2", "www.user2@email.com", "user2_pswd", "0000-00-00"),
                new Account(3, "User3", "www.user3@email.com", "user3_pswd", "0000-00-00"),
                new Account(4, "User4", "www.user4@email.com", "user4_pswd", "0000-00-00"),
                new Account(5, "User5", "www.user5@email.com", "user5_pswd", "0000-00-00"),
                new Account(6, "User6", "www.user6@email.com", "user6_pswd", "0000-00-00"),
                new Account(7, "User7", "www.user7@email.com", "user7_pswd", "0000-00-00"),
                new Account(8, "User8", "www.user8@email.com", "user8_pswd", "0000-00-00"),
                new Account(9, "User9", "www.user9@email.com", "user9_pswd", "0000-00-00"),
                new Account(10, "User10", "www.user10@email.com", "user10_pswd", "0000-00-00")
            };
            var exporter = new DataExporter(typeof(Account), users);

            // Act
            exporter.ExportData(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.xml"), TransferType.XML, SqlTable.UserInfo);

            // Assert
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.xml"))) { Assert.Fail(); }
        }

        [TestMethod]
        public void ExportData_UserTableToPDF_FileCreated()
        {
            // Arrange
            var users = new List<Object>
            {
                new Account(1, "User1", "www.user1@email.com", "user1_pswd", "0000-00-00"),
                new Account(2, "User2", "www.user2@email.com", "user2_pswd", "0000-00-00"),
                new Account(3, "User3", "www.user3@email.com", "user3_pswd", "0000-00-00"),
                new Account(4, "User4", "www.user4@email.com", "user4_pswd", "0000-00-00"),
                new Account(5, "User5", "www.user5@email.com", "user5_pswd", "0000-00-00"),
                new Account(6, "User6", "www.user6@email.com", "user6_pswd", "0000-00-00"),
                new Account(7, "User7", "www.user7@email.com", "user7_pswd", "0000-00-00"),
                new Account(8, "User8", "www.user8@email.com", "user8_pswd", "0000-00-00"),
                new Account(9, "User9", "www.user9@email.com", "user9_pswd", "0000-00-00"),
                new Account(10, "User10", "www.user10@email.com", "user10_pswd", "0000-00-00")
            };
            var exporter = new DataExporter(typeof(Account), users);

            // Act
            exporter.ExportData(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.pdf"), TransferType.PDF, SqlTable.UserInfo);

            // Assert
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.pdf"))) { Assert.Fail(); }
        }

        [TestMethod]
        public void ExportData_ProductTableToXML_FileCreated()
        {
            // Arrange
            var products = new List<Object>
            {
                new Product(1, "Product1", "Producer1", 10.99f, 8, "Category1", "Test Description"),
                new Product(2, "Product2", "Producer2", 11.99f, 10, "Category2", "Test Description"),
                new Product(3, "Product3", "Producer3", 12.99f, 12, "Category3", "Test Description"),
                new Product(4, "Product4", "Producer4", 13.99f, 14, "Category4", "Test Description"),
                new Product(5, "Product5", "Producer5", 14.99f, 16, "Category5", "Test Description"),
            };
            var exporter = new DataExporter(typeof(Account), products);

            // Act
            exporter.ExportData(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Products.xml"), TransferType.XML, SqlTable.ProductInfo);

            // Assert
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Products.xml"))) { Assert.Fail(); }
        }

        [TestMethod]
        public void ExportData_ProductTableToPDF_FileCreated()
        {
            // Arrange
            var products = new List<Object>
            {
                new Product(1, "Product1", "Producer1", 10.99f, 8, "Category1", "Test Description"),
                new Product(2, "Product2", "Producer2", 11.99f, 10, "Category2", "Test Description"),
                new Product(3, "Product3", "Producer3", 12.99f, 12, "Category3", "Test Description"),
                new Product(4, "Product4", "Producer4", 13.99f, 14, "Category4", "Test Description"),
                new Product(5, "Product5", "Producer5", 14.99f, 16, "Category5", "Test Description"),
            };
            var exporter = new DataExporter(typeof(Account), products);

            // Act
            exporter.ExportData(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Products.pdf"), TransferType.PDF, SqlTable.ProductInfo);

            // Assert
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Products.pdf"))) { Assert.Fail(); }
        }
    }
}
