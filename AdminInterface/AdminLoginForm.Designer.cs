namespace AdminInterface
{
    partial class AdminLoginForm
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
            this.lb_error_bottom = new System.Windows.Forms.Label();
            this.lb_error_top = new System.Windows.Forms.Label();
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
            this.gb_login.Controls.Add(this.lb_error_bottom);
            this.gb_login.Controls.Add(this.lb_error_top);
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
            // lb_error_bottom
            // 
            this.lb_error_bottom.AutoSize = true;
            this.lb_error_bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_bottom.ForeColor = System.Drawing.Color.Red;
            this.lb_error_bottom.Location = new System.Drawing.Point(67, 171);
            this.lb_error_bottom.Name = "lb_error_bottom";
            this.lb_error_bottom.Size = new System.Drawing.Size(282, 16);
            this.lb_error_bottom.TabIndex = 8;
            this.lb_error_bottom.Text = "Talk to an administrator if the problem persists.";
            this.lb_error_bottom.Visible = false;
            // 
            // lb_error_top
            // 
            this.lb_error_top.AutoSize = true;
            this.lb_error_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_top.ForeColor = System.Drawing.Color.Red;
            this.lb_error_top.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lb_error_top.Location = new System.Drawing.Point(106, 154);
            this.lb_error_top.Name = "lb_error_top";
            this.lb_error_top.Size = new System.Drawing.Size(194, 16);
            this.lb_error_top.TabIndex = 7;
            this.lb_error_top.Text = "Wrong Username or Password.";
            this.lb_error_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_error_top.Visible = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(295, 90);
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
            this.tb_password.Location = new System.Drawing.Point(119, 110);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(170, 28);
            this.tb_password.TabIndex = 3;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(21, 113);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(89, 22);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(119, 64);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(170, 28);
            this.tb_username.TabIndex = 1;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(21, 67);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(92, 22);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username";
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.gb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECommerceApp Admin Interface";
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
        private System.Windows.Forms.Label lb_error_top;
        private System.Windows.Forms.Label lb_error_bottom;
    }
}

