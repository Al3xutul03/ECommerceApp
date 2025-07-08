using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.DataHandling;
using Utils.MySQLInterface;

namespace AdminInterface
{
    public partial class ExportWindow : Form
    {
        private TransferType transferType;
        private SqlTable table;
        private string filePath;

        public TransferType TransferType { get { return transferType; } }
        public SqlTable Table { get { return table; } }
        public string FilePath { get { return filePath; } }

        static private Dictionary<int, TransferType> indexToTransferType = new Dictionary<int, TransferType>
        {
            { 0, TransferType.PDF },
            { 1, TransferType.XML }
        };

        static private Dictionary<int, SqlTable> indexToSQLTable = new Dictionary<int, SqlTable>
        {
            { 0, SqlTable.AdminInfo },
            { 1, SqlTable.UserInfo },
            { 2, SqlTable.ProductInfo }
        };

        static private Dictionary<TransferType, string> transferTypeToExtension = new Dictionary<TransferType, string>
        {
            { TransferType.PDF, ".pdf" },
            { TransferType.XML, ".xml" }
        };

        public ExportWindow()
        {
            InitializeComponent();

            cb_export_type.SelectedIndex = 0;
            cb_item_type.SelectedIndex = 0;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            transferType = indexToTransferType[cb_export_type.SelectedIndex];
            table = indexToSQLTable[cb_item_type.SelectedIndex];

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "ExportTable" + transferTypeToExtension[transferType];
                saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
