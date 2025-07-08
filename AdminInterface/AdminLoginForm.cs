using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.MySQLInterface;
using Utils.DataFormats;

namespace AdminInterface
{
    public partial class AdminLoginForm : Form
    {
        private MySQLConnector connector;
        private MySQLParser parser;

        public Account LoggedAccount { get; private set; }
        public MySQLParser Parser { get { return parser; } }

        public AdminLoginForm()
        {
            InitializeComponent();

            connector = new MySQLConnector(Program.SQLConnectionPath);
            parser = new MySQLParser(connector);
        }

        private async void btn_confirm_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            
            await parser.ConnectAsync();
            DataTable adminTable = await parser.GetTable(SqlTable.AdminInfo);

            bool exists = false;
            Account loggedAccount = null;
            foreach ( DataRow row in adminTable.Rows )
            {
                var account = new Account(row);
                if (account.Username == username &&
                    account.Password == password)
                {
                    exists = true;
                    loggedAccount = account;
                }
            }

            if (exists)
            {
                this.LoggedAccount = loggedAccount;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lb_error_top.Visible = true;
                lb_error_bottom.Visible = true;
            }
        }

        private void LoginForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
