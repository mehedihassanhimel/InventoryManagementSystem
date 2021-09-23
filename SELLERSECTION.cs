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
    public partial class SELLERSECTION : Form
    {
        public SELLERSECTION()
        {
            InitializeComponent();
        }

        private void AdProMangebutton_Click(object sender, EventArgs e)
        {
            OrdersSection orderSection = new OrdersSection();
            orderSection.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellerHomebutton_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form = new Form1();
            form.Show();
        }
    }
}
