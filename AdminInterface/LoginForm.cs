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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btn_confirm_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            var connector = new MySQLConnector(Program.SQLConnectionPath);
            var parser = new MySQLParser(SqlTable.AdminInfo);
            await parser.ConnectAsync(connector);
            DataTable adminTable = await parser.GetTable();

            bool exists = false;
            foreach ( DataRow row in adminTable.Rows )
            {
                var account = new Account(row);
                if (account.username == username &&
                    account.password == password)
                {
                    exists = true;
                }
            }

            if (exists)
            {
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
