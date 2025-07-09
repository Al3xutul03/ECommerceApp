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
using Utils.MySQLInterface;

namespace UserInterface
{
    public partial class MainUserWindow : Form
    {
        private Account loggedAccount;
        private MySQLParser parser;
        private SuccessWindow successWindow;

        private string searchString;
        private string category;

        private Product selectedProduct;
        private List<Product> products = new List<Product>();
        private List<Product> shoppingCartProducts = new List<Product>();
        private Dictionary<Product, int> cartQuantity = new Dictionary<Product, int>();

        static private Dictionary<int, string> indexToCategory = new Dictionary<int, string>
        {
            { 0, string.Empty },
            { 1, "Electronics" },
            { 2, "Clothes" },
            { 3, "Fruits and Vegetables" },
            { 4, "Home Decor" }
        };

        public MainUserWindow(Account loggedAccount, MySQLParser mySQLParser)
        {
            InitializeComponent();

            this.loggedAccount = loggedAccount;
            this.parser = mySQLParser;
        }

        private void SetProductList(List<Product> newProducts)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = newProducts;
            list_products.DataSource = bindingSource;
        }

        private async Task UpdateProductDB()
        {
            products.Clear();
            DataTable productTable = await parser.GetTable(SqlTable.ProductInfo, searchString, category, null, null, SortType.None);
            foreach (DataRow row in productTable.Rows) { products.Add(new Product(row)); }

            SetProductList(products);
        }

        private void SetSelectedProuct()
        {
            selectedProduct = (Product)list_products.SelectedItem;
            lb_name.Text = selectedProduct.Name;
            lb_producer.Text = selectedProduct.Producer;
            lb_price.Text = selectedProduct.Price.ToString();
            lb_description.Text = selectedProduct.Description;

            int currentStock = selectedProduct.Stock;
            if (currentStock > 50) { lb_stock.Text = "Currently Available"; }
            else if (currentStock > 0) { lb_stock.Text = "Limited Stock"; }
            else { lb_stock.Text = "Unavailable"; }
        }

        private void SetCartList(List<Product> newProducts)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = newProducts;
            list_cart.DataSource = bindingSource;
        }

        private async void MainUserWindow_Load(object sender, EventArgs e)
        {
            tsl_connected_as.Text += this.loggedAccount.Username;

            DataTable productTable = await parser.GetTable(SqlTable.ProductInfo);
            foreach (DataRow row in productTable.Rows) { products.Add(new Product(row)); }

            SetProductList(products);
            SetSelectedProuct();
            SetCartList(shoppingCartProducts);
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            searchString = tb_search.Text;
            await UpdateProductDB();
        }

        private async void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = indexToCategory[cb_category.SelectedIndex];
            await UpdateProductDB();
        }

        private void list_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedProuct();
        }

        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
            shoppingCartProducts.Add(selectedProduct);
            SetCartList(shoppingCartProducts);
            if (cartQuantity.ContainsKey(selectedProduct)) { cartQuantity[selectedProduct]++; }
            else { cartQuantity.Add(selectedProduct, 1); }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            var selected = (Product)list_cart.SelectedItem;
            shoppingCartProducts.Remove(selected);
            SetCartList(shoppingCartProducts);
            cartQuantity[selected]--;
        }

        private async void btn_checkout_Click(object sender, EventArgs e)
        {
            int noProducts = 0;
            foreach(KeyValuePair<Product, int> pair in cartQuantity)
            {
                if (pair.Value > 0) { noProducts++; }
                pair.Key.Stock -= pair.Value;
                if (pair.Key.Stock <= 0) { await parser.DeleteRow(SqlTable.ProductInfo, pair.Key.Id); }
                else { await parser.UpdateRow(pair.Key); }
            }

            products.Clear();
            DataTable productTable = await parser.GetTable(SqlTable.ProductInfo);
            foreach (DataRow row in productTable.Rows) { products.Add(new Product(row)); }

            SetProductList(products);
            SetSelectedProuct();
            shoppingCartProducts.Clear();
            cartQuantity.Clear();
            SetCartList(shoppingCartProducts);

            if (noProducts > 0)
            {
                var window = new SuccessWindow();
                window.Show();
            }
        }
    }
}
