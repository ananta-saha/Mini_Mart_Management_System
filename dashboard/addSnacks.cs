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

namespace dashboard
{
    public partial class addSnacks : Form
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Anoy1;Integrated Security=True"; 

        public addSnacks()
        {
            InitializeComponent();
        }

        private void addSnacks_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_add_snacks_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Number.Text) || string.IsNullOrWhiteSpace(txt_Name.Text) ||
                    string.IsNullOrWhiteSpace(txt_quantity.Text) || string.IsNullOrWhiteSpace(txt_price.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                int itemNumber = int.Parse(txt_Number.Text);
                string itemName = txt_Name.Text.Trim();
                int quantity = int.Parse(txt_quantity.Text);
                decimal price = decimal.Parse(txt_price.Text);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Items (Item_Number, Item_Name, Quantity, Price) VALUES (@num, @name, @qty, @price)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@num", itemNumber);
                        cmd.Parameters.AddWithValue("@name", itemName);
                        cmd.Parameters.AddWithValue("@qty", quantity);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Snack added successfully!");
                txt_Number.Clear();
                txt_Name.Clear();
                txt_quantity.Clear();
                txt_price.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Item Number, Quantity, and Price.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            snacks g1 = new snacks();
            g1.Show();
            this.Hide();
        }   
    }
}