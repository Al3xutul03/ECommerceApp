using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.DataFormats;

namespace AdminInterface
{
    public partial class AddAccountWindow : Form
    {
        private Account account;

        public Account Account { get { return account; } }

        public AddAccountWindow()
        {
            InitializeComponent();

            this.account = new Account(0, null, null, null, null);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            account.username = tb_username.Text;
            account.email = tb_email.Text;
            account.password = tb_password.Text;
            account.creation_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void EditAccountWindow_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
