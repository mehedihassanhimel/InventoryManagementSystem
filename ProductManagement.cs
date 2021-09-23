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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tafsir\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (productDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    productDataGridView.CurrentRow.Selected = true;
            //    productIdtextBox.Text = productDataGridView.Rows[e.RowIndex].Cells["ProductId"].FormattedValue.ToString();
            //    productNametextBox.Text = productDataGridView.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString();
            //    productQuantitytextBox.Text = productDataGridView.Rows[e.RowIndex].Cells["ProductQuantity"].FormattedValue.ToString();
            //    productPricetextBox.Text = productDataGridView.Rows[e.RowIndex].Cells["ProductPrice"].FormattedValue.ToString();
            //    productDetailstextBox.Text = productDataGridView.Rows[e.RowIndex].Cells["ProductDetails"].FormattedValue.ToString();
            //    productCategorycomboBox.SelectedValue = productDataGridView.Rows[e.RowIndex].Cells["ProductCategory"].FormattedValue.ToString();

            //}
            productIdtextBox.Text = productDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            productNametextBox.Text = productDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            productQuantitytextBox.Text = productDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            productPricetextBox.Text = productDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            productDetailstextBox.Text = productDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            productCategorycomboBox.SelectedValue = productDataGridView.SelectedRows[0].Cells[5].Value.ToString();

        }

        void ProductCategoryList()  
        {
                string myQuery = "select * from CategoryTable1";
                con.Open();
                SqlCommand cmd = new SqlCommand(myQuery, con);
         
                
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CategoryName", typeof(string));
                SqlDataReader reader = cmd.ExecuteReader(); 
                dataTable.Load(reader);
                productCategorycomboBox.ValueMember = "CategoryName";
                productCategorycomboBox.DataSource = dataTable;
                selectCategorycomboBox.ValueMember = "CategoryName";
                selectCategorycomboBox.DataSource = dataTable;
                con.Close();
               
        }

       

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            ProductCategoryList();
            ProductDataView();
        }

        void SelectCategoryList()  
        {
            
            try
            {
                con.Open();
                string myQuery = "select * from ProductTable1 where ProductCategory='" + selectCategorycomboBox.SelectedValue.ToString() + "'";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                productDataGridView.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }
           

        }

        void ProductDataView()
        {
            try
            {
                con.Open();
                string myQuery = "select * from ProductTable1";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                productDataGridView.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }
        }


      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButtonProduc_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "insert into ProductTable1 values('" + productIdtextBox.Text + "','" + productNametextBox.Text + "','" + productQuantitytextBox.Text
                    + "','" + productPricetextBox.Text + "','" + productDetailstextBox.Text +"','" + productCategorycomboBox.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query,con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Product Added Successfully ");
                con.Close();
                ProductDataView();
                


            }
            catch { }
        }

        private void productQuantitytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void producDetailstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeButtonProduct_Click(object sender, EventArgs e)
        {
            if (productIdtextBox.Text == "")
            {
                MessageBox.Show("Enter Product Id First ");
            }
            else
            {
                con.Open();
                string myQuery = "delete from ProductTable1 where ProductId='" + productIdtextBox.Text + "'";
                
                SqlCommand cmd = new SqlCommand(myQuery, con);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                con.Close();
                ProductDataView();

            }
        }

        private void editButtonProduct_Click(object sender, EventArgs e)
        {
            try
            {
              
                {
                    con.Open();
                    string query = "update ProductTable1 set ProductName='" + productNametextBox.Text + "',ProductQuantity='" + productQuantitytextBox.Text + "',ProductPrice='" + productPricetextBox.Text + "',ProductDetails='" + productDetailstextBox.Text + "',ProductCategory='" + productCategorycomboBox.SelectedValue.ToString() + "' where ProductId=" + productIdtextBox.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Product Updated Successfully ");
                    con.Close();
                    ProductDataView();
                }

            }
            catch { }
        }

        private void clearProductbutton_Click(object sender, EventArgs e)
        {
            productIdtextBox.Text = "";
            productNametextBox.Text = "";
            productQuantitytextBox.Text = "";
            productPricetextBox.Text = "";
            productDetailstextBox.Text = "";
            productCategorycomboBox.SelectedValue = "";
        }

        private void selectPCategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButtonbutton_Click(object sender, EventArgs e)
        {
            SelectCategoryList();
        }

        private void ProBackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMINSECTION admin = new ADMINSECTION();
            admin.Show();
        }
    }
}
