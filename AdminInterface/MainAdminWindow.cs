using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Utils.DataFormats;
using Utils.DataHandling;
using Utils.MySQLInterface;

namespace AdminInterface
{
    public partial class MainAdminWindow : Form
    {
        private Account loggedAccount;
        private MySQLParser parser;
        private CurrentView currentView;

        private int selectedId;
        private object selectedItem;

        private string searchString = string.Empty;
        private SortType sortType = SortType.None;

        private Dictionary<int, SortType> sortIndexMap = new Dictionary<int, SortType>
        {
            { 0, SortType.None },
            { 1, SortType.Ascending },
            { 2, SortType.Descending }
        };

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

        private async Task SetCurrentView(CurrentView currentView)
        {
            this.currentView = currentView;
            tsl_current_view.Text = "Current View: " + currentView.ToString();

            SqlColumn searchColumn = (currentView == CurrentView.Admins ||
                                      currentView == CurrentView.Users) ? SqlColumn.Username : SqlColumn.ProductName;
            itemTables[currentView] = (await parser.GetTable(viewToTable[currentView],
                searchString, null, new List<SqlColumn>{searchColumn}, sortType)).Rows;

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
            tsl_connected_as.Text += loggedAccount.Username;

            await SetCurrentView(CurrentView.Admins);
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

            selectedId = -1;
            selectedItem = null;
        }

        private async void btn_edit_selected_Click(object sender, EventArgs e)
        {
            if (selectedItem == null) return;

            int affectedRows;
            if (selectedItem is Account)
            {
                using (EditAccountWindow window = new EditAccountWindow((Account)selectedItem))
                {
                    if (window.ShowDialog() == DialogResult.OK)
                    {
                        affectedRows = await parser.UpdateRow(viewToTable[currentView], window.Account);
                        if (affectedRows != 1) { Console.WriteLine($"Something went wrong while editing item (ID: {selectedId})"); }
                        await SetCurrentView(currentView);
                    }
                }
            }
            else if (selectedItem is Product)
            {
                using (ProductWindow window = new ProductWindow((Product)selectedItem))
                {
                    if (window.ShowDialog() == DialogResult.OK)
                    {
                        affectedRows = await parser.UpdateRow(window.Product);
                        if (affectedRows != 1) { Console.WriteLine($"Something went wrong while editing item (ID: {selectedId})"); }
                        await SetCurrentView(currentView);
                    }
                }
            }
        }

        private async void btn_delete_selected_Click(object sender, EventArgs e)
        {
            if (selectedItem == null) return;

            int affectedRows = await parser.DeleteRow(viewToTable[currentView], selectedId);
            if (affectedRows != 1) { Console.WriteLine($"Something went wrong while deleting item (ID: {selectedId})"); }
            await SetCurrentView(currentView);
        }

        private async void btn_add_item_Click(object sender, EventArgs e)
        {
            int affectedRows;
            if (currentView == CurrentView.Admins ||
                currentView == CurrentView.Users)
            {
                using (AddAccountWindow window = new AddAccountWindow())
                {
                    if (window.ShowDialog() == DialogResult.OK)
                    {
                        affectedRows = await parser.InsertRow(viewToTable[currentView], window.Account);
                        if (affectedRows != 1) { Console.WriteLine($"Something went wrong while editing item (ID: {selectedId})"); }
                        await SetCurrentView(currentView);
                    }
                }
            }
            else if (currentView == CurrentView.Products)
            {
                using (ProductWindow window = new ProductWindow(null))
                {
                    if (window.ShowDialog() == DialogResult.OK)
                    {
                        affectedRows = await parser.InsertRow(window.Product);
                        if (affectedRows != 1) { Console.WriteLine($"Something went wrong while editing item (ID: {selectedId})"); }
                        await SetCurrentView(currentView);
                    }
                }
            }
        }

        private async void tsmi_view_admins_Click(object sender, EventArgs e) { await SetCurrentView(CurrentView.Admins); }

        private async void tsmi_view_users_Click(object sender, EventArgs e) { await SetCurrentView(CurrentView.Users); }

        private async void tsmi_view_products_Click(object sender, EventArgs e) { await SetCurrentView(CurrentView.Products); }

        private void list_database_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selected = list_database.SelectedItem;

            if (currentView == CurrentView.Admins ||
                currentView == CurrentView.Users)
            {
                Account account = selected as Account;

                lb_id.Text = account.Id.ToString();
                lb_username.Text = account.Username;
                lb_email.Text = account.Email;
                lb_creation_date.Text = account.CreationDate;

                selectedId = account.Id;
            }
            if (currentView == CurrentView.Products)
            {
                Product product = selected as Product;

                lb_id.Text = product.Id.ToString();
                lb_product_name.Text = product.Name;
                lb_producer.Text = product.Producer;
                lb_description.Text = product.Description;
                lb_category.Text = product.Category;
                lb_price.Text = product.Price.ToString();
                lb_available_stock.Text = product.Stock.ToString();

                selectedId = product.Id;
            }

            selectedItem = selected;
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            searchString = tb_search.Text;
            await SetCurrentView(currentView);
        }

        private async void cb_sortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortType = sortIndexMap[cb_sortby.SelectedIndex];
            await SetCurrentView(currentView);
        }

        private async void tsmi_export_Click(object sender, EventArgs e)
        {
            using (ExportWindow window = new ExportWindow())
            {
                if (window.ShowDialog() == DialogResult.OK)
                {
                    var collection = (await parser.GetTable(window.Table)).Rows;

                    List<object> list = new List<object>();
                    foreach (DataRow row in collection)
                    {
                        switch (window.Table)
                        {
                            case SqlTable.AdminInfo: list.Add(new Account(row)); break;
                            case SqlTable.UserInfo: list.Add(new Account(row)); break;
                            case SqlTable.ProductInfo: list.Add(new Product(row)); break;
                            default: break;
                        }
                    }

                    Type type = typeof(Account);
                    switch (window.Table)
                    {
                        case SqlTable.AdminInfo: type = typeof(Account); break;
                        case SqlTable.UserInfo: type = typeof(Account); break;
                        case SqlTable.ProductInfo: type = typeof(Product); break;
                        default: break;
                    }

                    var exporter = new DataExporter(type, list);
                    exporter.ExportData(window.FilePath, window.TransferType, window.Table);
                }
            }
        }
    }

    internal enum CurrentView
    {
        Admins, Users, Products
    }
}
