﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.DataFormats;
using Utils.MySQLInterface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserInterface
{
    public partial class RegisterForm : Form
    {
        private MySQLParser parser;

        private Dictionary<Error, Label> errors = new Dictionary<Error, Label>();

        public RegisterForm(MySQLParser parser)
        {
            InitializeComponent();

            this.parser = parser;
            this.errors = new Dictionary<Error, Label>
            {
                { Error.TakenUsername, lb_error_username },
                { Error.WrongConfirmPassword, lb_error_confirm_password }
            };
        }

        private void HideErrors()
        {
            foreach (Label error in errors.Values) { error.Hide(); }
        }

        private async void btn_signup_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            string confirmPassword = tb_confirm_password.Text;

            this.HideErrors();
            if (password != confirmPassword)
            {
                errors[Error.WrongConfirmPassword].Show();
                return;
            }

            DataTable userTable = await parser.GetTable(SqlTable.UserInfo);

            bool exists = false;
            foreach (DataRow row in userTable.Rows)
            {
                var account = new Account(row);
                if (account.username == username)
                {
                    exists = true;
                }
            }

            if (exists)
            {
                errors[Error.TakenUsername].Show();
                return;
            }

            // Implement Account Creation Later
        }

        private void linklb_go_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }

    public enum Error
    {
        TakenUsername, WrongConfirmPassword
    }
}
