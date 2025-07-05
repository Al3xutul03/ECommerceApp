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

namespace AdminInterface
{
    public partial class MainAdminWindow : Form
    {
        private Account loggedAccount;
        private MySQLParser parser;
        private CurrentView currentView;

        private Dictionary<CurrentView, SqlTable> viewToTable = new Dictionary<CurrentView, SqlTable>
        {
            { CurrentView.Admins, SqlTable.AdminInfo },
            { CurrentView.Users, SqlTable.UserInfo },
            { CurrentView.Products, SqlTable.ProductInfo }
        };

        private Dictionary<CurrentView, DataRowCollection> itemTables = new Dictionary<CurrentView, DataRowCollection>();

        private Dictionary<CurrentView, Action> changeSelectedType;

        public MainAdminWindow(Account loggedAccount, MySQLParser mySQLParser)
        {
            InitializeComponent();

            this.loggedAccount = loggedAccount;
            this.parser = mySQLParser;

            changeSelectedType = new Dictionary<CurrentView, Action>
            {
                { CurrentView.Admins, ChangeSelectedToAccounts },
                { CurrentView.Users, ChangeSelectedToAccounts },
                { CurrentView.Products, ChangeSelectedToProducts }
            };
        }

        private void SetCurrentView(CurrentView currentView)
        {
            this.currentView = currentView;
            tsl_current_view.Text = "Current View: " + currentView.ToString();

            var bindingSource = new BindingSource();
            List<object> list = new List<object>();
            foreach(DataRow row in itemTables[currentView])
            {
                switch(currentView)
                {
                    case CurrentView.Admins: list.Add(new Account(row)); break;
                    case CurrentView.Users: list.Add(new Account(row)); break;
                    case CurrentView.Products: list.Add(new Product(row)); break;
                    default: break;
                }
            }

            bindingSource.DataSource = list;
            list_database.DataSource = bindingSource;

            changeSelectedType[currentView]();
        }

        private async void MainAdminWindow_Load(object sender, EventArgs e)
        {
            tsl_connected_as.Text += loggedAccount.username;

            itemTables.Add(CurrentView.Admins, (await parser.GetTable(SqlTable.AdminInfo)).Rows);
            itemTables.Add(CurrentView.Users, (await parser.GetTable(SqlTable.UserInfo)).Rows);
            itemTables.Add(CurrentView.Products, (await parser.GetTable(SqlTable.ProductInfo)).Rows);

            SetCurrentView(CurrentView.Admins);
        }

        private void ChangeSelectedToAccounts()
        {
            RemoveSelected();

            // Hide Unecessary
            lb_producer_title.Hide();
            lb_producer.Hide();
            lb_description_title.Hide();
            lb_description.Hide();
            lb_product_name_title.Hide();
            lb_product_name.Hide();
            lb_available_stock_title.Hide();
            lb_available_stock.Hide();
            lb_price_title.Hide();
            lb_price.Hide();
            lb_category_title.Hide();
            lb_category.Hide();

            // Show Necessary
            lb_username_title.Show();
            lb_username.Show();
            lb_email_title.Show();
            lb_email.Show();
            lb_creation_date_title.Show();
            lb_creation_date.Show();

            gb_selected.Height = 210;
        }

        private void ChangeSelectedToProducts()
        {
            RemoveSelected();

            // Hide Unecessary
            lb_username_title.Hide();
            lb_username.Hide();
            lb_email_title.Hide();
            lb_email.Hide();
            lb_creation_date_title.Hide();
            lb_creation_date.Hide();

            // Show Necessary
            lb_producer_title.Show();
            lb_producer.Show();
            lb_description_title.Show();
            lb_description.Show();
            lb_product_name_title.Show();
            lb_product_name.Show();
            lb_available_stock_title.Show();
            lb_available_stock.Show();
            lb_price_title.Show();
            lb_price.Show();
            lb_category_title.Show();
            lb_category.Show();

            gb_selected.Height = 250;
        }

        private void RemoveSelected()
        {
            lb_available_stock.Text = string.Empty;
            lb_creation_date.Text = string.Empty;
            lb_description.Text = string.Empty;
            lb_id.Text = string.Empty;
            lb_username.Text = string.Empty;
            lb_product_name.Text = string.Empty;
            lb_producer.Text = string.Empty;
            lb_email.Text = string.Empty;
            lb_price.Text = string.Empty;
            lb_category.Text = string.Empty;
        }

        private void btn_edit_selected_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_selected_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {

        }

        private void tsmi_view_admins_Click(object sender, EventArgs e) { SetCurrentView(CurrentView.Admins); }

        private void tsmi_view_users_Click(object sender, EventArgs e) { SetCurrentView(CurrentView.Users); }

        private void tsmi_view_products_Click(object sender, EventArgs e) { SetCurrentView(CurrentView.Products); }

        private void list_database_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selected = list_database.SelectedItem;

            if (currentView == CurrentView.Admins ||
                currentView == CurrentView.Users)
            {
                Account account = selected as Account;

                lb_id.Text = account.id.ToString();
                lb_username.Text = account.username;
                lb_email.Text = account.email;
                lb_creation_date.Text = account.creation_date;
            }
            if (currentView == CurrentView.Products)
            {
                Product product = selected as Product;

                lb_id.Text = product.id.ToString();
                lb_product_name.Text = product.name;
                lb_producer.Text = product.producer;
                lb_description.Text = product.description;
                lb_category.Text = product.category;
                lb_price.Text = product.price.ToString();
                lb_available_stock.Text = product.stock.ToString();
            }
        }
    }

    internal enum CurrentView
    {
        Admins, Users, Products
    }
}
