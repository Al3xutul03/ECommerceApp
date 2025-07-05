using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInterface
{
    internal static class Program
    {
        public static string SQLConnectionPath = "MySQL_connection.xml";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (AdminLoginForm loginForm = new AdminLoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainAdminWindow(loginForm.LoggedAccount, loginForm.Parser));
                }
            }
        }
    }
}
