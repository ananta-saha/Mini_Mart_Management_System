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
    public partial class Addfruits : Form
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Anoy2;Integrated Security=True";

        public Addfruits()
        {
            InitializeComponent();
        }

        private void Btn_add_fruits_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Number_fruits.Text) || string.IsNullOrWhiteSpace(txt_Name_fruits.Text) ||
                    string.IsNullOrWhiteSpace(txt_quantity_fruits.Text) || string.IsNullOrWhiteSpace(txt_price_fruits.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                int itemNumber = int.Parse(txt_Number_fruits.Text);
                string itemName = txt_Name_fruits.Text.Trim();
                int quantity = int.Parse(txt_quantity_fruits.Text);
                decimal price = decimal.Parse(txt_price_fruits.Text);
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

                MessageBox.Show("Fruit added successfully!");
                txt_Number_fruits.Clear();
                txt_Name_fruits.Clear();
                txt_quantity_fruits.Clear();
                txt_price_fruits.Clear();
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

        private void btn_back_fruits_Click(object sender, EventArgs e)
        {
            fruits f = new fruits();
            f.Show();
            this.Hide();
        }
    }
}