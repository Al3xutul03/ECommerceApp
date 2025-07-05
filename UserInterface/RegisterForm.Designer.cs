using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_register = new System.Windows.Forms.GroupBox();
            this.lb_error_username = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_confirm_password = new System.Windows.Forms.TextBox();
            this.lb_confirm_password = new System.Windows.Forms.Label();
            this.linklb_go_back = new System.Windows.Forms.LinkLabel();
            this.lb_go_back = new System.Windows.Forms.Label();
            this.lb_error_confirm_password = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.gb_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_register
            // 
            this.gb_register.Controls.Add(this.lb_error_username);
            this.gb_register.Controls.Add(this.tb_email);
            this.gb_register.Controls.Add(this.lb_email);
            this.gb_register.Controls.Add(this.tb_confirm_password);
            this.gb_register.Controls.Add(this.lb_confirm_password);
            this.gb_register.Controls.Add(this.linklb_go_back);
            this.gb_register.Controls.Add(this.lb_go_back);
            this.gb_register.Controls.Add(this.lb_error_confirm_password);
            this.gb_register.Controls.Add(this.btn_signup);
            this.gb_register.Controls.Add(this.tb_password);
            this.gb_register.Controls.Add(this.lb_password);
            this.gb_register.Controls.Add(this.tb_username);
            this.gb_register.Controls.Add(this.lb_username);
            this.gb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_register.Location = new System.Drawing.Point(200, 25);
            this.gb_register.Name = "gb_register";
            this.gb_register.Size = new System.Drawing.Size(400, 400);
            this.gb_register.TabIndex = 1;
            this.gb_register.TabStop = false;
            this.gb_register.Text = "Register";
            // 
            // lb_error_username
            // 
            this.lb_error_username.AutoSize = true;
            this.lb_error_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_username.ForeColor = System.Drawing.Color.Red;
            this.lb_error_username.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lb_error_username.Location = new System.Drawing.Point(118, 285);
            this.lb_error_username.Name = "lb_error_username";
            this.lb_error_username.Size = new System.Drawing.Size(168, 16);
            this.lb_error_username.TabIndex = 14;
            this.lb_error_username.Text = "Username is already taken";
            this.lb_error_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_error_username.Visible = false;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(43, 243);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(320, 28);
            this.tb_email.TabIndex = 13;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(39, 218);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 22);
            this.lb_email.TabIndex = 12;
            this.lb_email.Text = "Email";
            // 
            // tb_confirm_password
            // 
            this.tb_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirm_password.Location = new System.Drawing.Point(43, 187);
            this.tb_confirm_password.Name = "tb_confirm_password";
            this.tb_confirm_password.Size = new System.Drawing.Size(320, 28);
            this.tb_confirm_password.TabIndex = 11;
            // 
            // lb_confirm_password
            // 
            this.lb_confirm_password.AutoSize = true;
            this.lb_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirm_password.Location = new System.Drawing.Point(39, 162);
            this.lb_confirm_password.Name = "lb_confirm_password";
            this.lb_confirm_password.Size = new System.Drawing.Size(156, 22);
            this.lb_confirm_password.TabIndex = 10;
            this.lb_confirm_password.Text = "Confirm Password";
            // 
            // linklb_go_back
            // 
            this.linklb_go_back.AutoSize = true;
            this.linklb_go_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_go_back.Location = new System.Drawing.Point(238, 366);
            this.linklb_go_back.Name = "linklb_go_back";
            this.linklb_go_back.Size = new System.Drawing.Size(88, 16);
            this.linklb_go_back.TabIndex = 9;
            this.linklb_go_back.TabStop = true;
            this.linklb_go_back.Text = "Sign Up here!";
            this.linklb_go_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_go_back_LinkClicked);
            // 
            // lb_go_back
            // 
            this.lb_go_back.AutoSize = true;
            this.lb_go_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_go_back.Location = new System.Drawing.Point(70, 366);
            this.lb_go_back.Name = "lb_go_back";
            this.lb_go_back.Size = new System.Drawing.Size(162, 16);
            this.lb_go_back.TabIndex = 8;
            this.lb_go_back.Text = "Already have an account?";
            // 
            // lb_error_confirm_password
            // 
            this.lb_error_confirm_password.AutoSize = true;
            this.lb_error_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_confirm_password.ForeColor = System.Drawing.Color.Red;
            this.lb_error_confirm_password.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lb_error_confirm_password.Location = new System.Drawing.Point(70, 285);
            this.lb_error_confirm_password.Name = "lb_error_confirm_password";
            this.lb_error_confirm_password.Size = new System.Drawing.Size(269, 16);
            this.lb_error_confirm_password.TabIndex = 7;
            this.lb_error_confirm_password.Text = "Confirm Password must match the Password";
            this.lb_error_confirm_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_error_confirm_password.Visible = false;
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Location = new System.Drawing.Point(288, 318);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(43, 131);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(320, 28);
            this.tb_password.TabIndex = 3;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(39, 106);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(89, 22);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(43, 75);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(320, 28);
            this.tb_username.TabIndex = 1;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(39, 50);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(92, 22);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.gb_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECommerceApp";
            this.gb_register.ResumeLayout(false);
            this.gb_register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_register;
        private System.Windows.Forms.LinkLabel linklb_go_back;
        private System.Windows.Forms.Label lb_go_back;
        private System.Windows.Forms.Label lb_error_confirm_password;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_confirm_password;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_confirm_password;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_error_username;
    }
}