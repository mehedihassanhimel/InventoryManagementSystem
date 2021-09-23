using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemProject
{
    public partial class ADMINSECTION : Form
    {
        public ADMINSECTION()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryManagement category = new CategoryManagement();
            category.Show();
            
        }

        private void AdProMangebutton_Click(object sender, EventArgs e)
        {
            ProductManagement product = new ProductManagement();
            product.Show();
           
        }

        private void AdSellersbutton_Click(object sender, EventArgs e)
        {
            SellerManagement seller = new SellerManagement();
            seller.Show();
        }

        private void AdminHomebutton_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form = new Form1();
            form.Show();
        }
    }
}
