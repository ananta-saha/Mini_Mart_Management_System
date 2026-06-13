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
    public partial class UpdateFruits : Form
    {
        public UpdateFruits()
        {
            InitializeComponent();
        }

        private void btn_Update_fruits_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_updateNumber_fruits.Text) || string.IsNullOrEmpty(txt_updateName_fruits.Text) ||
                string.IsNullOrEmpty(txt_updateQn_fruits.Text) || string.IsNullOrEmpty(txt_updatePrice_fruits.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Fruit fruit = new Fruit();
            fruit.Item_Number = txt_updateNumber_fruits.Text;
            fruit.Item_Name = txt_updateName_fruits.Text;
            fruit.Quantity = txt_updateQn_fruits.Text; 
            fruit.Price = txt_updatePrice_fruits.Text;  

            if (fruit.update(fruit))
            {
                MessageBox.Show("Fruit updated successfully.");
                txt_updateNumber_fruits.Clear();
                txt_updateName_fruits.Clear();
                txt_updateQn_fruits.Clear();
                txt_updatePrice_fruits.Clear();
            }
            else
            {
                MessageBox.Show("Error updating fruit. Please try again.");
            }
        }

        private void btn_back_fruits_Click(object sender, EventArgs e)
        {
            fruits f4 = new fruits();
            f4.Show();
            this.Hide();
        }

        private void UpdateFruits_Load(object sender, EventArgs e)
        {

        }

        public class Fruit
        {
            public string Item_Number { get; set; }
            public string Item_Name { get; set; }
            public string Quantity { get; set; } 
            public string Price { get; set; }    

            private string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Anoy2;Integrated Security=True";

            public bool update(Fruit f)
            {
                bool success = false;
                SqlConnection sqc = new SqlConnection(connection);
                try
                {
                    string q = "UPDATE Items SET Item_Name=@Item_Name, Quantity=@Quantity, " +
                        "Price=@Price WHERE Item_Number=@Item_Number";

                    sqc.Open();
                    SqlCommand cmd = new SqlCommand(q, sqc);
                    cmd.Parameters.AddWithValue("@Item_Name", f.Item_Name);
                    cmd.Parameters.AddWithValue("@Item_Number", f.Item_Number);
                    cmd.Parameters.AddWithValue("@Quantity", f.Quantity);
                    cmd.Parameters.AddWithValue("@Price", f.Price);

                    if (sqc.State == ConnectionState.Open)
                    {
                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            success = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    sqc.Close();
                }
                return success;
            }
        }
    }
}