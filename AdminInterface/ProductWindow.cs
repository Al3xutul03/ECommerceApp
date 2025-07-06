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
    public partial class ProductWindow : Form
    {
        private Product product;

        public Product Product { get { return product; } }

        public ProductWindow(Product product)
        {
            InitializeComponent();

            if (product != null)
            {
                tb_name.Text = product.name;
                tb_producer.Text = product.producer;
                nud_price.Value = (decimal)product.price;
                nud_stock.Value = product.stock;
                tb_category.Text = product.category;
                rtb_description.Text = product.description;
            }

            this.product = product;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if (this.product != null)
            {
                product.name = tb_name.Text;
                product.producer = tb_producer.Text;
                product.price = (float)nud_price.Value;
                product.stock = (int)nud_stock.Value;
                product.category = tb_category.Text;
                product.description = rtb_description.Text;
            }
            else
            {
                this.product = new Product(
                    id: 0,
                    name: tb_name.Text,
                    producer: tb_producer.Text,
                    price: (float)nud_price.Value,
                    stock: (int)nud_stock.Value,
                    category: tb_category.Text,
                    description: rtb_description.Text);
            }
        }

        private void ProductWindow_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
