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
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tafsir\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
      
        void CategoryDataView()
        {
            try
            {
                con.Open();
                string myQuery = "select * from CategoryTable1";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                categoryDataGridView.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }
        }
        
        
        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void addButtonCategory_Click(object sender, EventArgs e)
        {
            //string categoryId = categoryIdtextBox.Text;

            try
            {
                con.Open();

                
                string query = "insert into CategoryTable1 values('" + categoryIdtextBox.Text + "','" + categoryNametextBox.Text + "','" + categoryDetailstextBox.Text
                    + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Category Added Successfully");
                con.Close();
                CategoryDataView();


            }
            catch { }
        }

        private void removeButtonCategory_Click(object sender, EventArgs e)
        {
            if (categoryNametextBox.Text == "")
            {
                MessageBox.Show("Enter Category Name First ");
            }
            else
            {
                
                string myQuery = "delete from CategoryTable1 where CategoryName='" + categoryNametextBox.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(myQuery, con);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                con.Close();
                CategoryDataView();

            }
        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (categoryDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    categoryDataGridView.CurrentRow.Selected = true;
            //    categoryIdtextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells["CategoryId"].FormattedValue.ToString();
            //    categoryNametextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells["CategoryName"].FormattedValue.ToString();
            //    categoryDetailstextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells["CategoryDetails"].FormattedValue.ToString();

            //}
            categoryIdtextBox.Text = categoryDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            categoryNametextBox.Text = categoryDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            categoryDetailstextBox.Text = categoryDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void editButtonCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryIdtextBox.Text == "" || categoryNametextBox.Text == "" || categoryDetailstextBox.Text == "")
                {
                    MessageBox.Show("Select Your Category First ");
                }

                else
                {

                    con.Open();

                    //SqlCommand cmd = new SqlCommand("update CategoryTable1 set CategoryId='" + categoryIdtextBox.Text + "',CategoryDetails='" + categoryDetailstextBox.Text + "' where CategoryName='" + categoryNametextBox.Text + "'", con);
                    string query = "update CategoryTable1 set CategoryId='" + categoryIdtextBox.Text + "',CategoryDetails='" + categoryDetailstextBox.Text + "' where CategoryName='" + categoryNametextBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Category Updated Successfully");
                    con.Close();
                    CategoryDataView();
                }

            }
            catch { }
        }

        private void clearButtonCategory_Click(object sender, EventArgs e)
        {
            categoryIdtextBox.Text = "";
            categoryNametextBox.Text = "";
            categoryDetailstextBox.Text = "";
        }

        private void categorySearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string myQuery = "select * from CategoryTable1 where CategoryName='" + categoryNametextBox.Text + "'";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                categoryDataGridView.DataSource = dataSet.Tables[0];
                con.Close();
                CategoryDataView();


            }
            catch { }
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            CategoryDataView();
        }

        private void CatBackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMINSECTION admin = new ADMINSECTION();
            admin.Show();
        }
    }
}
