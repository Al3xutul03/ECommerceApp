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

namespace UserInterface
{
    public partial class UserLoginForm : Form
    {
        private MySQLConnector connector;
        private MySQLParser parser;

        public Account Account { get; private set; }
        public MySQLParser Parser { get { return parser; } }

        public UserLoginForm()
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
            DataTable adminTable = await parser.GetTable(SqlTable.UserInfo);

            bool exists = false;
            Account wantedAccount = null;
            foreach ( DataRow row in adminTable.Rows )
            {
                var account = new Account(row);
                if (account.Username == username &&
                    account.Password == password)
                {
                    exists = true;
                    wantedAccount = account;
                }
            }

            if (exists)
            {
                this.DialogResult = DialogResult.OK;
                Account = wantedAccount;
            }
            else
            {
                lb_error.Visible = true;
            }
        }

        private void LoginForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void linklb_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegisterForm registerForm = new RegisterForm(parser))
            {
                this.Hide();
                DialogResult result = registerForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = result;
                    this.Account = registerForm.Account;
                }
                else
                {
                    this.Show();
                }
            }
        }
    }
}
