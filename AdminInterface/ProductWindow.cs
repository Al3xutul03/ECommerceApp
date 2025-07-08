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
                tb_name.Text = product.Name;
                tb_producer.Text = product.Producer;
                nud_price.Value = (decimal)product.Price;
                nud_stock.Value = product.Stock;
                tb_category.Text = product.Category;
                rtb_description.Text = product.Description;
            }

            this.product = product;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if (this.product != null)
            {
                product.Name = tb_name.Text;
                product.Producer = tb_producer.Text;
                product.Price = (float)nud_price.Value;
                product.Stock = (int)nud_stock.Value;
                product.Category = tb_category.Text;
                product.Description = rtb_description.Text;
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
