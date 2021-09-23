using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new UserManagement());
      
            //Application.Run(new CategoryManagement());
            //Application.Run(new ProductManagement());
            //Application.Run(new Form1());
            //Application.Run(new ADMINSECTION());
            //Application.Run(new SellerManagement());
            //Application.Run(new SalesAndOrders());
            Application.Run(new OrdersSection());
            //Application.Run(new SELLERSECTION());
        }
    }
}
