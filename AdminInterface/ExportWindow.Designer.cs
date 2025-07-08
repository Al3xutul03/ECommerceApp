namespace AdminInterface
{
    partial class ExportWindow
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
            this.cb_export_type = new System.Windows.Forms.ComboBox();
            this.cb_item_type = new System.Windows.Forms.ComboBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_export_type
            // 
            this.cb_export_type.FormattingEnabled = true;
            this.cb_export_type.Items.AddRange(new object[] {
            "PDF",
            "XML"});
            this.cb_export_type.Location = new System.Drawing.Point(78, 55);
            this.cb_export_type.Name = "cb_export_type";
            this.cb_export_type.Size = new System.Drawing.Size(121, 24);
            this.cb_export_type.TabIndex = 0;
            // 
            // cb_item_type
            // 
            this.cb_item_type.FormattingEnabled = true;
            this.cb_item_type.Items.AddRange(new object[] {
            "Admins",
            "Users",
            "Products"});
            this.cb_item_type.Location = new System.Drawing.Point(78, 118);
            this.cb_item_type.Name = "cb_item_type";
            this.cb_item_type.Size = new System.Drawing.Size(121, 24);
            this.cb_item_type.TabIndex = 1;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(78, 203);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(121, 23);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ExportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.cb_item_type);
            this.Controls.Add(this.cb_export_type);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_export_type;
        private System.Windows.Forms.ComboBox cb_item_type;
        private System.Windows.Forms.Button btn_export;
    }
}