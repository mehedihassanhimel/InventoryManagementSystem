using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystemProject
{
    public partial class SellerManagement : Form
    {
        public SellerManagement()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tafsir\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void SellerDataView()
        {
            try
            {
                con.Open();
                string myQuery = "select * from SellersTable1";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                sellerDataGridView.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }
        }

        private void sellerAddButton_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string query = "insert into SellersTable1 values('" + sellerIdtextBox.Text + "','" + sellerNametextBox.Text + "','" + sellerPhonetextBox.Text
                    + "','" + sellerPasswordtextBox.Text + "','" + sellerAddresstextBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Seller Added Successfully ");
                con.Close();
                SellerDataView();




            }
            catch { }


        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellerManagement_Load(object sender, EventArgs e)
        {
            SellerDataView();
        }

        private void sellerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sellerIdtextBox.Text = sellerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            sellerNametextBox.Text = sellerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            sellerPhonetextBox.Text = sellerDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            sellerPasswordtextBox.Text = sellerDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            sellerAddresstextBox.Text = sellerDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void sellerRemoveButton_Click(object sender, EventArgs e)
        {
            if (sellerIdtextBox.Text == "")
            {
                MessageBox.Show("Enter Seller Id First ");
            }
            else
            {
                
                string myQuery = "delete from SellersTable1 where SellerId='" + sellerIdtextBox.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(myQuery, con);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                con.Close();
                SellerDataView();


            }
        }

        private void sellerEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (  sellerNametextBox.Text == "" ||  sellerIdtextBox.Text == "" || sellerPhonetextBox.Text == "" || sellerPasswordtextBox.Text == "" || sellerAddresstextBox.Text == "")
                {
                    MessageBox.Show("Select Your Seller First ");
                }

                else
                {

                    con.Open();
                    string query = "update SellersTable1 set SellerName='" + sellerNametextBox.Text + "',SellerPhone='" + sellerPhonetextBox.Text + "',SellerPassword='" + sellerPasswordtextBox.Text + "',SellerAddress='" + sellerAddresstextBox.Text + "' where SellerId='" + sellerIdtextBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Seller Updated Successfully");
                    con.Close();
                    SellerDataView();
                }
            }
            catch { }
        }

        void SearchSeller()
        {

            try
            {
                con.Open();
                string myQuery = "select * from SellersTable1 where SellerId='" + sellerIdtextBox.Text + "'";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                sellerDataGridView.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }


        }

        private void sellerSearchbutton_Click(object sender, EventArgs e)
        {
            SearchSeller();
        }

        private void sellerClearButton_Click(object sender, EventArgs e)
        {
            sellerIdtextBox.Text = "";
            sellerNametextBox.Text = "";
            sellerPhonetextBox.Text = "";
            sellerPasswordtextBox.Text = "";
            sellerAddresstextBox.Text = "";

        }

        private void SellBackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMINSECTION admin = new ADMINSECTION();
            admin.Show();
        }
    }
}

