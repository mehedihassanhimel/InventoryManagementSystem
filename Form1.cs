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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tafsir\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*')
            {
                showCheckPassword.BringToFront();
                passwordTextBox.PasswordChar = '\0';
            }
            else if (passwordTextBox.PasswordChar == '\0')
            {
                showCheckPassword.BringToFront();
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            userNametextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            if(userNametextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show(" Enter User Information First ");
            }
            else
            {
                if (selectUsercomboBox.SelectedIndex > -1)
                {
                    if (selectUsercomboBox.SelectedItem.ToString() =="ADMIN")
                    {
                        if (userNametextBox.Text == "Admin" && passwordTextBox.Text == "Admin")
                        {
                            ADMINSECTION adminsection = new ADMINSECTION();
                            adminsection.Show();
                            

                        }
                        else
                        {
                            MessageBox.Show("Enter Your Correct Information");
                        }
                    }

                    else
                    {
                        //MessageBox.Show(" Seller Section: ");
                        con.Open();
                        string query = "select count(*) from SellersTable1 where SellerName='" + userNametextBox.Text + "' and SellerPassword='" + passwordTextBox.Text + "'";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if(table.Rows[0][0].ToString()=="1")
                        {
                            this.Hide();
                            SELLERSECTION seller = new SELLERSECTION();
                            seller.Show();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Information Not Matching");
                        }
                        con.Close();
                    }
                }

                else
                {
                    MessageBox.Show(" Sorry!! Indentify Yourself First ");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectUsercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
