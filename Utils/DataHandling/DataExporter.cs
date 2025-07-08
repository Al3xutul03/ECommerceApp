using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Quality;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Utils.DataFormats;
using Utils.MySQLInterface;

namespace Utils.DataHandling
{
    public class DataExporter
    {
        private Type dataType;
        private List<Object> dataList = new List<Object>();

        private Dictionary<TransferType, Action<string, SqlTable>> exportMap;
        private Dictionary<SqlTable, Action<Table>> tableMap;

        static private Dictionary<SqlTable, string> exportFileName = new Dictionary<SqlTable, string>
        {
            { SqlTable.AdminInfo, "Admins" },
            { SqlTable.UserInfo, "Users" },
            { SqlTable.ProductInfo, "Products" }
        };

        static private Dictionary<SqlTable, DataType> tableToDataType = new Dictionary<SqlTable, DataType>
        {
            { SqlTable.AdminInfo, DataType.Account },
            { SqlTable.UserInfo, DataType.Account },
            { SqlTable.ProductInfo, DataType.Product }
        };

        static private Dictionary<SqlTable, Type> tableToListType = new Dictionary<SqlTable, Type>
        {
            { SqlTable.AdminInfo, typeof(List<Account>) },
            { SqlTable.UserInfo, typeof(List<Account>) },
            { SqlTable.ProductInfo, typeof(List<Product>) }
        };

        static private Dictionary<SqlTable, Type> tableToType = new Dictionary<SqlTable, Type>
        {
            { SqlTable.AdminInfo, typeof(Account) },
            { SqlTable.UserInfo, typeof(Account) },
            { SqlTable.ProductInfo, typeof(Product) }
        };

        public DataExporter(Type dataType, List<Object> dataList)
        {
            this.dataType = dataType;
            this.dataList = dataList;

            this.exportMap = new Dictionary<TransferType, Action<string, SqlTable>>
            {
                { TransferType.PDF, ExportToPDF },
                { TransferType.XML, ExportToXML }
            };

            this.tableMap = new Dictionary<SqlTable, Action<Table>>
            {
                { SqlTable.AdminInfo, CreateAccountTable },
                { SqlTable.UserInfo, CreateAccountTable },
                { SqlTable.ProductInfo, CreateProductTable },
            };
        }

        public void ExportData(string filePath, TransferType exportType, SqlTable sqlTableSource)
        {
            exportMap[exportType](filePath, sqlTableSource);
        }

        private void ExportToPDF(string filepath, SqlTable sqlTableSource)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            GlobalFontSettings.UseWindowsFontsUnderWindows = true;
            var document = new Document();
            document.Info.Title = $"{exportFileName[sqlTableSource]} List";

            Section section = document.AddSection();
            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.LeftMargin = "2.5cm";
            section.PageSetup.RightMargin = "2.5cm";
            section.PageSetup.TopMargin = "2.5cm";
            section.PageSetup.BottomMargin = "2.5cm";

            Paragraph title = section.AddParagraph(document.Info.Title, "Heading1");
            title.Format.SpaceAfter = "1cm";
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.Font.Size = 16;

            Table table = section.AddTable();
            table.Borders.Width = 0.75;
            table.Borders.Color = Colors.Black;
            table.Rows.LeftIndent = 0;
            table.Format.Alignment = ParagraphAlignment.Center;

            this.tableMap[sqlTableSource](table);

            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();

            try
            {
                pdfRenderer.PdfDocument.Save(filepath);
                Console.WriteLine($"PDF created successfully at: {filepath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error saving PDF: {e.Message}");
            }
        }

        private void ExportToXML(string filePath, SqlTable sqlTableSource)
        {
            XmlSerializer serializer = new XmlSerializer(tableToListType[sqlTableSource]);

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", ""); // Removes default XML namespaces like xmlns:xsi, xmlns:xsd

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; // Makes the XML readable (indents elements)
            settings.IndentChars = "  "; // Use 2 spaces for indentation
            settings.NewLineOnAttributes = false; // Keep attributes on the same line
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    // You can directly use the FileStream or wrap it in a StreamWriter for encoding control
                    using (StreamWriter writer = new StreamWriter(fileStream, System.Text.Encoding.UTF8))
                    {
                        if (sqlTableSource == SqlTable.AdminInfo ||
                            sqlTableSource == SqlTable.UserInfo)
                        {
                            var list = new List<Account>();
                            foreach (var data in dataList) { list.Add(data as Account); }
                            serializer.Serialize(writer, list, ns);
                        }
                        else
                        {
                            var list = new List<Product>();
                            foreach (var data in dataList) { list.Add(data as Product); }
                            serializer.Serialize(writer, list, ns);
                        }
                        Console.WriteLine($"Successfully exported {dataList.Count} items to {filePath}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error exporting products to XML: {e.Message}");
            }
        }

        private void CreateAccountTable(Table table)
        {
            var list = new List<Account>();
            foreach (var data in dataList) { list.Add(data as Account); }

            table.AddColumn("2cm"); // ID
            table.AddColumn("3cm"); // Username
            table.AddColumn("5cm"); // Email
            table.AddColumn("3cm"); // Creation Date

            // Add Table Header Row
            Row headerRow = table.AddRow();
            headerRow.Format.Font.Bold = true;
            headerRow.Shading.Color = Colors.LightGray; // Header background color
            headerRow.Height = "0.8cm"; // Height for the header row
            headerRow.VerticalAlignment = VerticalAlignment.Center; // Vertically center text in header

            // Add content to header cells
            headerRow.Cells[0].AddParagraph("ID");
            headerRow.Cells[1].AddParagraph("Username");
            headerRow.Cells[2].AddParagraph("Email");
            headerRow.Cells[3].AddParagraph("Creation Date");

            // Align header text explicitly
            headerRow.Cells[0].Format.Alignment = ParagraphAlignment.Center;
            headerRow.Cells[3].Format.Alignment = ParagraphAlignment.Center;

            foreach (var account in list)
            {
                Row row = table.AddRow();
                row.Height = "0.7cm";
                row.VerticalAlignment = VerticalAlignment.Center;
                if (table.Rows.Count % 2 == 0) { row.Shading.Color = Colors.WhiteSmoke; }

                row.Cells[0].AddParagraph(account.Id.ToString());
                row.Cells[1].AddParagraph(account.Username);
                row.Cells[2].AddParagraph(account.Email);
                row.Cells[3].AddParagraph(account.CreationDate);

                // Align data text explicitly
                row.Cells[0].Format.Alignment = ParagraphAlignment.Center;
                row.Cells[3].Format.Alignment = ParagraphAlignment.Center;
            }
        }

        private void CreateProductTable(Table table)
        {
            var list = new List<Product>();
            foreach (var data in dataList) { list.Add(data as Product); }

            table.AddColumn("2cm"); // ID
            table.AddColumn("3cm"); // Product Name
            table.AddColumn("3cm"); // Producer
            table.AddColumn("2cm"); // Price
            table.AddColumn("2cm"); // Stock
            table.AddColumn("3cm"); // Category

            // Add Table Header Row
            Row headerRow = table.AddRow();
            headerRow.Format.Font.Bold = true;
            headerRow.Shading.Color = Colors.LightGray; // Header background color
            headerRow.Height = "0.8cm"; // Height for the header row
            headerRow.VerticalAlignment = VerticalAlignment.Center; // Vertically center text in header

            // Add content to header cells
            headerRow.Cells[0].AddParagraph("ID");
            headerRow.Cells[1].AddParagraph("Name");
            headerRow.Cells[2].AddParagraph("Producer");
            headerRow.Cells[3].AddParagraph("Price");
            headerRow.Cells[4].AddParagraph("Stock");
            headerRow.Cells[5].AddParagraph("Category");

            // Align header text explicitly
            headerRow.Cells[0].Format.Alignment = ParagraphAlignment.Center;
            headerRow.Cells[3].Format.Alignment = ParagraphAlignment.Right;
            headerRow.Cells[4].Format.Alignment = ParagraphAlignment.Center;

            foreach (var product in list)
            {
                Row row = table.AddRow();
                row.Height = "0.7cm";
                row.VerticalAlignment = VerticalAlignment.Center;
                if (table.Rows.Count % 2 == 0) { row.Shading.Color = Colors.WhiteSmoke; }

                row.Cells[0].AddParagraph(product.Id.ToString());
                row.Cells[1].AddParagraph(product.Name);
                row.Cells[2].AddParagraph(product.Producer);
                row.Cells[3].AddParagraph(product.Price.ToString());
                row.Cells[4].AddParagraph(product.Stock.ToString());
                row.Cells[5].AddParagraph(product.Category);

                // Align data text explicitly
                row.Cells[0].Format.Alignment = ParagraphAlignment.Center;
                row.Cells[3].Format.Alignment = ParagraphAlignment.Right;
                row.Cells[4].Format.Alignment = ParagraphAlignment.Center;
            }
        }
    }

    public enum TransferType
    {
        PDF, XML
    }
}
