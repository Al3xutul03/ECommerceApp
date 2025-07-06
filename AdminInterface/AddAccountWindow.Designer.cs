namespace AdminInterface
{
    partial class AddAccountWindow
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
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(107, 95);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(155, 22);
            this.tb_email.TabIndex = 7;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(49, 101);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(47, 16);
            this.lb_email.TabIndex = 6;
            this.lb_email.Text = "Email :";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(107, 50);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(155, 22);
            this.tb_username.TabIndex = 5;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(20, 50);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(76, 16);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "Username :";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(23, 143);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(73, 16);
            this.lb_password.TabIndex = 8;
            this.lb_password.Text = "Password :";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(107, 137);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(155, 22);
            this.tb_password.TabIndex = 9;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(107, 218);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 10;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // AddAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccountWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_confirm;
    }
}