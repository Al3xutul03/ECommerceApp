namespace AdminInterface
{
    partial class MainAdminWindow
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
            this.ms_app_tabs = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_view = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_view_admins = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_view_users = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_view_products = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_app = new System.Windows.Forms.ToolStrip();
            this.tsl_connected_as = new System.Windows.Forms.ToolStripLabel();
            this.tss_separator = new System.Windows.Forms.ToolStripSeparator();
            this.tsl_current_view = new System.Windows.Forms.ToolStripLabel();
            this.gb_selected = new System.Windows.Forms.GroupBox();
            this.lb_category = new System.Windows.Forms.Label();
            this.lb_category_title = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_price_title = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_description_title = new System.Windows.Forms.Label();
            this.lb_available_stock = new System.Windows.Forms.Label();
            this.lb_available_stock_title = new System.Windows.Forms.Label();
            this.lb_producer = new System.Windows.Forms.Label();
            this.lb_producer_title = new System.Windows.Forms.Label();
            this.lb_product_name = new System.Windows.Forms.Label();
            this.lb_product_name_title = new System.Windows.Forms.Label();
            this.lb_creation_date = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_creation_date_title = new System.Windows.Forms.Label();
            this.lb_email_title = new System.Windows.Forms.Label();
            this.lb_id_title = new System.Windows.Forms.Label();
            this.lb_username_title = new System.Windows.Forms.Label();
            this.btn_edit_selected = new System.Windows.Forms.Button();
            this.btn_delete_selected = new System.Windows.Forms.Button();
            this.gb_list = new System.Windows.Forms.GroupBox();
            this.list_database = new System.Windows.Forms.ListBox();
            this.gb_db_options = new System.Windows.Forms.GroupBox();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.ms_app_tabs.SuspendLayout();
            this.ts_app.SuspendLayout();
            this.gb_selected.SuspendLayout();
            this.gb_list.SuspendLayout();
            this.gb_db_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_app_tabs
            // 
            this.ms_app_tabs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_app_tabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_view});
            this.ms_app_tabs.Location = new System.Drawing.Point(0, 0);
            this.ms_app_tabs.Name = "ms_app_tabs";
            this.ms_app_tabs.Size = new System.Drawing.Size(921, 30);
            this.ms_app_tabs.TabIndex = 0;
            this.ms_app_tabs.Text = "menuStrip1";
            // 
            // tsmi_file
            // 
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(46, 26);
            this.tsmi_file.Text = "File";
            // 
            // tsmi_view
            // 
            this.tsmi_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_view_admins,
            this.tsmi_view_users,
            this.tsmi_view_products});
            this.tsmi_view.Name = "tsmi_view";
            this.tsmi_view.Size = new System.Drawing.Size(55, 26);
            this.tsmi_view.Text = "View";
            // 
            // tsmi_view_admins
            // 
            this.tsmi_view_admins.Name = "tsmi_view_admins";
            this.tsmi_view_admins.Size = new System.Drawing.Size(149, 26);
            this.tsmi_view_admins.Text = "Admins";
            this.tsmi_view_admins.Click += new System.EventHandler(this.tsmi_view_admins_Click);
            // 
            // tsmi_view_users
            // 
            this.tsmi_view_users.Name = "tsmi_view_users";
            this.tsmi_view_users.Size = new System.Drawing.Size(149, 26);
            this.tsmi_view_users.Text = "Users";
            this.tsmi_view_users.Click += new System.EventHandler(this.tsmi_view_users_Click);
            // 
            // tsmi_view_products
            // 
            this.tsmi_view_products.Name = "tsmi_view_products";
            this.tsmi_view_products.Size = new System.Drawing.Size(149, 26);
            this.tsmi_view_products.Text = "Products";
            this.tsmi_view_products.Click += new System.EventHandler(this.tsmi_view_products_Click);
            // 
            // ts_app
            // 
            this.ts_app.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_app.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_app.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_connected_as,
            this.tss_separator,
            this.tsl_current_view});
            this.ts_app.Location = new System.Drawing.Point(0, 30);
            this.ts_app.Name = "ts_app";
            this.ts_app.Size = new System.Drawing.Size(921, 31);
            this.ts_app.TabIndex = 0;
            this.ts_app.Text = "toolStrip1";
            // 
            // tsl_connected_as
            // 
            this.tsl_connected_as.Name = "tsl_connected_as";
            this.tsl_connected_as.Size = new System.Drawing.Size(107, 28);
            this.tsl_connected_as.Text = "Connected As: ";
            // 
            // tss_separator
            // 
            this.tss_separator.Name = "tss_separator";
            this.tss_separator.Size = new System.Drawing.Size(6, 31);
            // 
            // tsl_current_view
            // 
            this.tsl_current_view.Name = "tsl_current_view";
            this.tsl_current_view.Size = new System.Drawing.Size(100, 28);
            this.tsl_current_view.Text = "Current View: ";
            // 
            // gb_selected
            // 
            this.gb_selected.Controls.Add(this.lb_category);
            this.gb_selected.Controls.Add(this.lb_category_title);
            this.gb_selected.Controls.Add(this.lb_price);
            this.gb_selected.Controls.Add(this.lb_price_title);
            this.gb_selected.Controls.Add(this.lb_description);
            this.gb_selected.Controls.Add(this.lb_description_title);
            this.gb_selected.Controls.Add(this.lb_available_stock);
            this.gb_selected.Controls.Add(this.lb_available_stock_title);
            this.gb_selected.Controls.Add(this.lb_producer);
            this.gb_selected.Controls.Add(this.lb_producer_title);
            this.gb_selected.Controls.Add(this.lb_product_name);
            this.gb_selected.Controls.Add(this.lb_product_name_title);
            this.gb_selected.Controls.Add(this.lb_creation_date);
            this.gb_selected.Controls.Add(this.lb_email);
            this.gb_selected.Controls.Add(this.lb_username);
            this.gb_selected.Controls.Add(this.lb_id);
            this.gb_selected.Controls.Add(this.lb_creation_date_title);
            this.gb_selected.Controls.Add(this.lb_email_title);
            this.gb_selected.Controls.Add(this.lb_id_title);
            this.gb_selected.Controls.Add(this.lb_username_title);
            this.gb_selected.Location = new System.Drawing.Point(25, 68);
            this.gb_selected.Name = "gb_selected";
            this.gb_selected.Size = new System.Drawing.Size(433, 300);
            this.gb_selected.TabIndex = 1;
            this.gb_selected.TabStop = false;
            this.gb_selected.Text = "Selected Item";
            // 
            // lb_category
            // 
            this.lb_category.Location = new System.Drawing.Point(117, 268);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(309, 16);
            this.lb_category.TabIndex = 19;
            // 
            // lb_category_title
            // 
            this.lb_category_title.AutoSize = true;
            this.lb_category_title.Location = new System.Drawing.Point(25, 268);
            this.lb_category_title.Name = "lb_category_title";
            this.lb_category_title.Size = new System.Drawing.Size(68, 16);
            this.lb_category_title.TabIndex = 18;
            this.lb_category_title.Text = "Category :";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(368, 93);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(0, 16);
            this.lb_price.TabIndex = 17;
            // 
            // lb_price_title
            // 
            this.lb_price_title.AutoSize = true;
            this.lb_price_title.Location = new System.Drawing.Point(309, 93);
            this.lb_price_title.Name = "lb_price_title";
            this.lb_price_title.Size = new System.Drawing.Size(44, 16);
            this.lb_price_title.TabIndex = 16;
            this.lb_price_title.Text = "Price :";
            // 
            // lb_description
            // 
            this.lb_description.Location = new System.Drawing.Point(117, 214);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(309, 54);
            this.lb_description.TabIndex = 15;
            // 
            // lb_description_title
            // 
            this.lb_description_title.AutoSize = true;
            this.lb_description_title.Location = new System.Drawing.Point(20, 214);
            this.lb_description_title.Name = "lb_description_title";
            this.lb_description_title.Size = new System.Drawing.Size(81, 16);
            this.lb_description_title.TabIndex = 14;
            this.lb_description_title.Text = "Description :";
            // 
            // lb_available_stock
            // 
            this.lb_available_stock.AutoSize = true;
            this.lb_available_stock.Location = new System.Drawing.Point(368, 33);
            this.lb_available_stock.Name = "lb_available_stock";
            this.lb_available_stock.Size = new System.Drawing.Size(0, 16);
            this.lb_available_stock.TabIndex = 13;
            // 
            // lb_available_stock_title
            // 
            this.lb_available_stock_title.AutoSize = true;
            this.lb_available_stock_title.Location = new System.Drawing.Point(246, 33);
            this.lb_available_stock_title.Name = "lb_available_stock_title";
            this.lb_available_stock_title.Size = new System.Drawing.Size(107, 16);
            this.lb_available_stock_title.TabIndex = 12;
            this.lb_available_stock_title.Text = "Available Stock :";
            // 
            // lb_producer
            // 
            this.lb_producer.Location = new System.Drawing.Point(117, 154);
            this.lb_producer.Name = "lb_producer";
            this.lb_producer.Size = new System.Drawing.Size(309, 60);
            this.lb_producer.TabIndex = 11;
            // 
            // lb_producer_title
            // 
            this.lb_producer_title.AutoSize = true;
            this.lb_producer_title.Location = new System.Drawing.Point(33, 154);
            this.lb_producer_title.Name = "lb_producer_title";
            this.lb_producer_title.Size = new System.Drawing.Size(68, 16);
            this.lb_producer_title.TabIndex = 10;
            this.lb_producer_title.Text = "Producer :";
            // 
            // lb_product_name
            // 
            this.lb_product_name.Location = new System.Drawing.Point(117, 93);
            this.lb_product_name.Name = "lb_product_name";
            this.lb_product_name.Size = new System.Drawing.Size(186, 61);
            this.lb_product_name.TabIndex = 9;
            // 
            // lb_product_name_title
            // 
            this.lb_product_name_title.AutoSize = true;
            this.lb_product_name_title.Location = new System.Drawing.Point(2, 93);
            this.lb_product_name_title.Name = "lb_product_name_title";
            this.lb_product_name_title.Size = new System.Drawing.Size(99, 16);
            this.lb_product_name_title.TabIndex = 8;
            this.lb_product_name_title.Text = "Product Name :";
            // 
            // lb_creation_date
            // 
            this.lb_creation_date.Location = new System.Drawing.Point(117, 214);
            this.lb_creation_date.Name = "lb_creation_date";
            this.lb_creation_date.Size = new System.Drawing.Size(309, 41);
            this.lb_creation_date.TabIndex = 7;
            // 
            // lb_email
            // 
            this.lb_email.Location = new System.Drawing.Point(117, 154);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(309, 40);
            this.lb_email.TabIndex = 6;
            // 
            // lb_username
            // 
            this.lb_username.Location = new System.Drawing.Point(117, 93);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(186, 46);
            this.lb_username.TabIndex = 5;
            // 
            // lb_id
            // 
            this.lb_id.Location = new System.Drawing.Point(117, 33);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(123, 16);
            this.lb_id.TabIndex = 4;
            // 
            // lb_creation_date_title
            // 
            this.lb_creation_date_title.AutoSize = true;
            this.lb_creation_date_title.Location = new System.Drawing.Point(6, 214);
            this.lb_creation_date_title.Name = "lb_creation_date_title";
            this.lb_creation_date_title.Size = new System.Drawing.Size(95, 16);
            this.lb_creation_date_title.TabIndex = 3;
            this.lb_creation_date_title.Text = "Creation Date :";
            // 
            // lb_email_title
            // 
            this.lb_email_title.AutoSize = true;
            this.lb_email_title.Location = new System.Drawing.Point(54, 154);
            this.lb_email_title.Name = "lb_email_title";
            this.lb_email_title.Size = new System.Drawing.Size(47, 16);
            this.lb_email_title.TabIndex = 2;
            this.lb_email_title.Text = "Email :";
            // 
            // lb_id_title
            // 
            this.lb_id_title.AutoSize = true;
            this.lb_id_title.Location = new System.Drawing.Point(75, 33);
            this.lb_id_title.Name = "lb_id_title";
            this.lb_id_title.Size = new System.Drawing.Size(26, 16);
            this.lb_id_title.TabIndex = 1;
            this.lb_id_title.Text = "ID :";
            // 
            // lb_username_title
            // 
            this.lb_username_title.AutoSize = true;
            this.lb_username_title.Location = new System.Drawing.Point(25, 93);
            this.lb_username_title.Name = "lb_username_title";
            this.lb_username_title.Size = new System.Drawing.Size(76, 16);
            this.lb_username_title.TabIndex = 0;
            this.lb_username_title.Text = "Username :";
            // 
            // btn_edit_selected
            // 
            this.btn_edit_selected.Location = new System.Drawing.Point(6, 35);
            this.btn_edit_selected.Name = "btn_edit_selected";
            this.btn_edit_selected.Size = new System.Drawing.Size(136, 37);
            this.btn_edit_selected.TabIndex = 8;
            this.btn_edit_selected.Text = "Edit Selected";
            this.btn_edit_selected.UseVisualStyleBackColor = true;
            this.btn_edit_selected.Click += new System.EventHandler(this.btn_edit_selected_Click);
            // 
            // btn_delete_selected
            // 
            this.btn_delete_selected.Location = new System.Drawing.Point(148, 35);
            this.btn_delete_selected.Name = "btn_delete_selected";
            this.btn_delete_selected.Size = new System.Drawing.Size(136, 37);
            this.btn_delete_selected.TabIndex = 9;
            this.btn_delete_selected.Text = "Delete Selected";
            this.btn_delete_selected.UseVisualStyleBackColor = true;
            this.btn_delete_selected.Click += new System.EventHandler(this.btn_delete_selected_Click);
            // 
            // gb_list
            // 
            this.gb_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_list.Controls.Add(this.list_database);
            this.gb_list.Location = new System.Drawing.Point(515, 68);
            this.gb_list.Name = "gb_list";
            this.gb_list.Size = new System.Drawing.Size(394, 452);
            this.gb_list.TabIndex = 2;
            this.gb_list.TabStop = false;
            this.gb_list.Text = "Database List";
            // 
            // list_database
            // 
            this.list_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_database.FormattingEnabled = true;
            this.list_database.ItemHeight = 22;
            this.list_database.Location = new System.Drawing.Point(6, 27);
            this.list_database.Name = "list_database";
            this.list_database.Size = new System.Drawing.Size(382, 422);
            this.list_database.TabIndex = 0;
            this.list_database.SelectedIndexChanged += new System.EventHandler(this.list_database_SelectedIndexChanged);
            // 
            // gb_db_options
            // 
            this.gb_db_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_db_options.Controls.Add(this.btn_edit_selected);
            this.gb_db_options.Controls.Add(this.btn_delete_selected);
            this.gb_db_options.Controls.Add(this.btn_add_item);
            this.gb_db_options.Location = new System.Drawing.Point(25, 426);
            this.gb_db_options.Name = "gb_db_options";
            this.gb_db_options.Size = new System.Drawing.Size(433, 91);
            this.gb_db_options.TabIndex = 3;
            this.gb_db_options.TabStop = false;
            this.gb_db_options.Text = "Database Options";
            // 
            // btn_add_item
            // 
            this.btn_add_item.Location = new System.Drawing.Point(290, 35);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(136, 37);
            this.btn_add_item.TabIndex = 10;
            this.btn_add_item.Text = "Add Item";
            this.btn_add_item.UseVisualStyleBackColor = true;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // MainAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 532);
            this.Controls.Add(this.gb_db_options);
            this.Controls.Add(this.gb_list);
            this.Controls.Add(this.gb_selected);
            this.Controls.Add(this.ts_app);
            this.Controls.Add(this.ms_app_tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms_app_tabs;
            this.Name = "MainAdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECommerceApp Admin Interface";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainAdminWindow_Load);
            this.ms_app_tabs.ResumeLayout(false);
            this.ms_app_tabs.PerformLayout();
            this.ts_app.ResumeLayout(false);
            this.ts_app.PerformLayout();
            this.gb_selected.ResumeLayout(false);
            this.gb_selected.PerformLayout();
            this.gb_list.ResumeLayout(false);
            this.gb_db_options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_app_tabs;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_view;
        private System.Windows.Forms.ToolStripMenuItem tsmi_view_admins;
        private System.Windows.Forms.ToolStripMenuItem tsmi_view_users;
        private System.Windows.Forms.ToolStripMenuItem tsmi_view_products;
        private System.Windows.Forms.ToolStrip ts_app;
        private System.Windows.Forms.ToolStripLabel tsl_connected_as;
        private System.Windows.Forms.ToolStripSeparator tss_separator;
        private System.Windows.Forms.ToolStripLabel tsl_current_view;
        private System.Windows.Forms.GroupBox gb_selected;
        private System.Windows.Forms.Label lb_email_title;
        private System.Windows.Forms.Label lb_id_title;
        private System.Windows.Forms.Label lb_username_title;
        private System.Windows.Forms.Label lb_creation_date_title;
        private System.Windows.Forms.Button btn_edit_selected;
        private System.Windows.Forms.Label lb_creation_date;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button btn_delete_selected;
        private System.Windows.Forms.GroupBox gb_list;
        private System.Windows.Forms.GroupBox gb_db_options;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.ListBox list_database;
        private System.Windows.Forms.Label lb_product_name_title;
        private System.Windows.Forms.Label lb_available_stock;
        private System.Windows.Forms.Label lb_available_stock_title;
        private System.Windows.Forms.Label lb_producer;
        private System.Windows.Forms.Label lb_producer_title;
        private System.Windows.Forms.Label lb_product_name;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_description_title;
        private System.Windows.Forms.Label lb_price_title;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.Label lb_category_title;
    }
}