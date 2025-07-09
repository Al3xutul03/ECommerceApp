namespace UserInterface
{
    partial class UserLoginForm
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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.linklb_register = new System.Windows.Forms.LinkLabel();
            this.lb_register = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.linklb_register);
            this.gb_login.Controls.Add(this.lb_register);
            this.gb_login.Controls.Add(this.lb_error);
            this.gb_login.Controls.Add(this.btn_confirm);
            this.gb_login.Controls.Add(this.tb_password);
            this.gb_login.Controls.Add(this.lb_password);
            this.gb_login.Controls.Add(this.tb_username);
            this.gb_login.Controls.Add(this.lb_username);
            this.gb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_login.Location = new System.Drawing.Point(200, 115);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(400, 200);
            this.gb_login.TabIndex = 0;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "Login";
            // 
            // linklb_register
            // 
            this.linklb_register.AutoSize = true;
            this.linklb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_register.Location = new System.Drawing.Point(232, 181);
            this.linklb_register.Name = "linklb_register";
            this.linklb_register.Size = new System.Drawing.Size(106, 16);
            this.linklb_register.TabIndex = 9;
            this.linklb_register.TabStop = true;
            this.linklb_register.Text = "Create one here!";
            this.linklb_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_register_LinkClicked);
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_register.Location = new System.Drawing.Point(63, 181);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(146, 16);
            this.lb_register.TabIndex = 8;
            this.lb_register.Text = "Don\'t have an account?";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lb_error.Location = new System.Drawing.Point(114, 149);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(194, 16);
            this.lb_error.TabIndex = 7;
            this.lb_error.Text = "Wrong Username or Password.";
            this.lb_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_error.Visible = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(305, 88);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(129, 108);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(170, 28);
            this.tb_password.TabIndex = 3;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(31, 111);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(89, 22);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(129, 62);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(170, 28);
            this.tb_username.TabIndex = 1;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(31, 65);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(92, 22);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username";
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.gb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECommerceApp";
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.LinkLabel linklb_register;
        private System.Windows.Forms.Label lb_register;
    }
}

