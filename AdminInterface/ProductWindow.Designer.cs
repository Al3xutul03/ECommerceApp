namespace AdminInterface
{
    partial class ProductWindow
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
            this.tb_producer = new System.Windows.Forms.TextBox();
            this.lb_producer = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.nud_stock = new System.Windows.Forms.NumericUpDown();
            this.lb_category = new System.Windows.Forms.Label();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_producer
            // 
            this.tb_producer.Location = new System.Drawing.Point(106, 75);
            this.tb_producer.Name = "tb_producer";
            this.tb_producer.Size = new System.Drawing.Size(236, 22);
            this.tb_producer.TabIndex = 13;
            // 
            // lb_producer
            // 
            this.lb_producer.AutoSize = true;
            this.lb_producer.Location = new System.Drawing.Point(22, 78);
            this.lb_producer.Name = "lb_producer";
            this.lb_producer.Size = new System.Drawing.Size(68, 16);
            this.lb_producer.TabIndex = 12;
            this.lb_producer.Text = "Producer :";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(106, 27);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(236, 22);
            this.tb_name.TabIndex = 11;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(40, 30);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(50, 16);
            this.lb_name.TabIndex = 10;
            this.lb_name.Text = "Name :";
            // 
            // nud_price
            // 
            this.nud_price.DecimalPlaces = 2;
            this.nud_price.Location = new System.Drawing.Point(106, 122);
            this.nud_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(98, 22);
            this.nud_price.TabIndex = 14;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(46, 124);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(44, 16);
            this.lb_price.TabIndex = 15;
            this.lb_price.Text = "Price :";
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Location = new System.Drawing.Point(43, 166);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(47, 16);
            this.lb_stock.TabIndex = 16;
            this.lb_stock.Text = "Stock :";
            // 
            // nud_stock
            // 
            this.nud_stock.Location = new System.Drawing.Point(106, 164);
            this.nud_stock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_stock.Name = "nud_stock";
            this.nud_stock.Size = new System.Drawing.Size(98, 22);
            this.nud_stock.TabIndex = 17;
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Location = new System.Drawing.Point(22, 208);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(68, 16);
            this.lb_category.TabIndex = 18;
            this.lb_category.Text = "Category :";
            // 
            // tb_category
            // 
            this.tb_category.Location = new System.Drawing.Point(106, 205);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(236, 22);
            this.tb_category.TabIndex = 19;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(12, 257);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(81, 16);
            this.lb_description.TabIndex = 20;
            this.lb_description.Text = "Description :";
            // 
            // rtb_description
            // 
            this.rtb_description.Location = new System.Drawing.Point(106, 257);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.Size = new System.Drawing.Size(236, 85);
            this.rtb_description.TabIndex = 21;
            this.rtb_description.Text = "";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(158, 368);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 22;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.rtb_description);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_category);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.nud_stock);
            this.Controls.Add(this.lb_stock);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.nud_price);
            this.Controls.Add(this.tb_producer);
            this.Controls.Add(this.lb_producer);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Window";
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_producer;
        private System.Windows.Forms.Label lb_producer;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.NumericUpDown nud_stock;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.Button btn_confirm;
    }
}