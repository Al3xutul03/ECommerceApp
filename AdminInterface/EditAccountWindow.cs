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
    public partial class EditAccountWindow : Form
    {
        private Account account;

        public Account Account { get { return account; } }

        public EditAccountWindow(Account account)
        {
            InitializeComponent();

            this.account = account;

            tb_username.Text = account.username;
            tb_email.Text = account.email;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            account.username = tb_username.Text;
            account.email = tb_email.Text;
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
