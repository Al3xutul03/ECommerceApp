namespace UserInterface
{
    partial class MainUserWindow
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
            this.ts_app = new System.Windows.Forms.ToolStrip();
            this.tsl_connected_as = new System.Windows.Forms.ToolStripLabel();
            this.gb_products = new System.Windows.Forms.GroupBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.lb_category = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.list_products = new System.Windows.Forms.ListBox();
            this.gb_selected = new System.Windows.Forms.GroupBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_producer = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.lb_description_title = new System.Windows.Forms.Label();
            this.lb_stock_title = new System.Windows.Forms.Label();
            this.lb_price_title = new System.Windows.Forms.Label();
            this.lb_producer_title = new System.Windows.Forms.Label();
            this.lb_name_title = new System.Windows.Forms.Label();
            this.btn_add_to_cart = new System.Windows.Forms.Button();
            this.gb_cart = new System.Windows.Forms.GroupBox();
            this.list_cart = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.ts_app.SuspendLayout();
            this.gb_products.SuspendLayout();
            this.gb_selected.SuspendLayout();
            this.gb_cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_app
            // 
            this.ts_app.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_app.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_app.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_connected_as});
            this.ts_app.Location = new System.Drawing.Point(0, 0);
            this.ts_app.Name = "ts_app";
            this.ts_app.Size = new System.Drawing.Size(1138, 25);
            this.ts_app.TabIndex = 0;
            // 
            // tsl_connected_as
            // 
            this.tsl_connected_as.Name = "tsl_connected_as";
            this.tsl_connected_as.Size = new System.Drawing.Size(107, 22);
            this.tsl_connected_as.Text = "Connected As: ";
            // 
            // gb_products
            // 
            this.gb_products.Controls.Add(this.cb_category);
            this.gb_products.Controls.Add(this.lb_category);
            this.gb_products.Controls.Add(this.btn_search);
            this.gb_products.Controls.Add(this.tb_search);
            this.gb_products.Controls.Add(this.list_products);
            this.gb_products.Location = new System.Drawing.Point(12, 41);
            this.gb_products.Name = "gb_products";
            this.gb_products.Size = new System.Drawing.Size(456, 426);
            this.gb_products.TabIndex = 1;
            this.gb_products.TabStop = false;
            this.gb_products.Text = "Product List";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "All",
            "Electronics",
            "Clothes",
            "Fruits and Vegetables",
            "Home Decor"});
            this.cb_category.Location = new System.Drawing.Point(316, 29);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(134, 24);
            this.cb_category.TabIndex = 4;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Location = new System.Drawing.Point(233, 34);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(68, 16);
            this.lb_category.TabIndex = 3;
            this.lb_category.Text = "Category :";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(142, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(6, 31);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(117, 22);
            this.tb_search.TabIndex = 1;
            // 
            // list_products
            // 
            this.list_products.FormattingEnabled = true;
            this.list_products.ItemHeight = 16;
            this.list_products.Location = new System.Drawing.Point(6, 59);
            this.list_products.Name = "list_products";
            this.list_products.Size = new System.Drawing.Size(444, 356);
            this.list_products.TabIndex = 0;
            this.list_products.SelectedIndexChanged += new System.EventHandler(this.list_products_SelectedIndexChanged);
            // 
            // gb_selected
            // 
            this.gb_selected.Controls.Add(this.lb_description);
            this.gb_selected.Controls.Add(this.lb_price);
            this.gb_selected.Controls.Add(this.lb_name);
            this.gb_selected.Controls.Add(this.lb_producer);
            this.gb_selected.Controls.Add(this.lb_stock);
            this.gb_selected.Controls.Add(this.lb_description_title);
            this.gb_selected.Controls.Add(this.lb_stock_title);
            this.gb_selected.Controls.Add(this.lb_price_title);
            this.gb_selected.Controls.Add(this.lb_producer_title);
            this.gb_selected.Controls.Add(this.lb_name_title);
            this.gb_selected.Controls.Add(this.btn_add_to_cart);
            this.gb_selected.Location = new System.Drawing.Point(488, 41);
            this.gb_selected.Name = "gb_selected";
            this.gb_selected.Size = new System.Drawing.Size(308, 426);
            this.gb_selected.TabIndex = 2;
            this.gb_selected.TabStop = false;
            this.gb_selected.Text = "Selected Product";
            // 
            // lb_description
            // 
            this.lb_description.Location = new System.Drawing.Point(9, 265);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(293, 77);
            this.lb_description.TabIndex = 10;
            // 
            // lb_price
            // 
            this.lb_price.Location = new System.Drawing.Point(87, 159);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(86, 16);
            this.lb_price.TabIndex = 9;
            // 
            // lb_name
            // 
            this.lb_name.Location = new System.Drawing.Point(87, 59);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(195, 49);
            this.lb_name.TabIndex = 8;
            // 
            // lb_producer
            // 
            this.lb_producer.Location = new System.Drawing.Point(87, 108);
            this.lb_producer.Name = "lb_producer";
            this.lb_producer.Size = new System.Drawing.Size(195, 51);
            this.lb_producer.TabIndex = 7;
            // 
            // lb_stock
            // 
            this.lb_stock.Location = new System.Drawing.Point(139, 188);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(163, 21);
            this.lb_stock.TabIndex = 6;
            this.lb_stock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_description_title
            // 
            this.lb_description_title.AutoSize = true;
            this.lb_description_title.Location = new System.Drawing.Point(6, 229);
            this.lb_description_title.Name = "lb_description_title";
            this.lb_description_title.Size = new System.Drawing.Size(81, 16);
            this.lb_description_title.TabIndex = 5;
            this.lb_description_title.Text = "Description :";
            // 
            // lb_stock_title
            // 
            this.lb_stock_title.AutoSize = true;
            this.lb_stock_title.Location = new System.Drawing.Point(184, 159);
            this.lb_stock_title.Name = "lb_stock_title";
            this.lb_stock_title.Size = new System.Drawing.Size(78, 16);
            this.lb_stock_title.TabIndex = 4;
            this.lb_stock_title.Text = "Availability :";
            // 
            // lb_price_title
            // 
            this.lb_price_title.AutoSize = true;
            this.lb_price_title.Location = new System.Drawing.Point(30, 159);
            this.lb_price_title.Name = "lb_price_title";
            this.lb_price_title.Size = new System.Drawing.Size(44, 16);
            this.lb_price_title.TabIndex = 3;
            this.lb_price_title.Text = "Price :";
            // 
            // lb_producer_title
            // 
            this.lb_producer_title.AutoSize = true;
            this.lb_producer_title.Location = new System.Drawing.Point(6, 108);
            this.lb_producer_title.Name = "lb_producer_title";
            this.lb_producer_title.Size = new System.Drawing.Size(68, 16);
            this.lb_producer_title.TabIndex = 2;
            this.lb_producer_title.Text = "Producer :";
            // 
            // lb_name_title
            // 
            this.lb_name_title.AutoSize = true;
            this.lb_name_title.Location = new System.Drawing.Point(24, 59);
            this.lb_name_title.Name = "lb_name_title";
            this.lb_name_title.Size = new System.Drawing.Size(50, 16);
            this.lb_name_title.TabIndex = 1;
            this.lb_name_title.Text = "Name :";
            // 
            // btn_add_to_cart
            // 
            this.btn_add_to_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_to_cart.Location = new System.Drawing.Point(55, 362);
            this.btn_add_to_cart.Name = "btn_add_to_cart";
            this.btn_add_to_cart.Size = new System.Drawing.Size(189, 53);
            this.btn_add_to_cart.TabIndex = 0;
            this.btn_add_to_cart.Text = "Add To Cart";
            this.btn_add_to_cart.UseVisualStyleBackColor = true;
            this.btn_add_to_cart.Click += new System.EventHandler(this.btn_add_to_cart_Click);
            // 
            // gb_cart
            // 
            this.gb_cart.Controls.Add(this.btn_checkout);
            this.gb_cart.Controls.Add(this.btn_remove);
            this.gb_cart.Controls.Add(this.list_cart);
            this.gb_cart.Location = new System.Drawing.Point(821, 41);
            this.gb_cart.Name = "gb_cart";
            this.gb_cart.Size = new System.Drawing.Size(308, 426);
            this.gb_cart.TabIndex = 11;
            this.gb_cart.TabStop = false;
            this.gb_cart.Text = "Shopping Cart";
            // 
            // list_cart
            // 
            this.list_cart.FormattingEnabled = true;
            this.list_cart.ItemHeight = 16;
            this.list_cart.Location = new System.Drawing.Point(6, 27);
            this.list_cart.Name = "list_cart";
            this.list_cart.Size = new System.Drawing.Size(296, 340);
            this.list_cart.TabIndex = 0;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(6, 380);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(141, 35);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Remove Selected";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(161, 380);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(141, 35);
            this.btn_checkout.TabIndex = 2;
            this.btn_checkout.Text = "Go To Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // MainUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 479);
            this.Controls.Add(this.gb_cart);
            this.Controls.Add(this.gb_selected);
            this.Controls.Add(this.gb_products);
            this.Controls.Add(this.ts_app);
            this.Name = "MainUserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECommerceApp";
            this.Load += new System.EventHandler(this.MainUserWindow_Load);
            this.ts_app.ResumeLayout(false);
            this.ts_app.PerformLayout();
            this.gb_products.ResumeLayout(false);
            this.gb_products.PerformLayout();
            this.gb_selected.ResumeLayout(false);
            this.gb_selected.PerformLayout();
            this.gb_cart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_app;
        private System.Windows.Forms.ToolStripLabel tsl_connected_as;
        private System.Windows.Forms.GroupBox gb_products;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ListBox list_products;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.GroupBox gb_selected;
        private System.Windows.Forms.Button btn_add_to_cart;
        private System.Windows.Forms.Label lb_description_title;
        private System.Windows.Forms.Label lb_stock_title;
        private System.Windows.Forms.Label lb_price_title;
        private System.Windows.Forms.Label lb_producer_title;
        private System.Windows.Forms.Label lb_name_title;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_producer;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.GroupBox gb_cart;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListBox list_cart;
    }
}