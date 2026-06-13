using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  // Added for database operations

namespace dashboard
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
        }

        public class Item
        {
            public string Item_Number { get; set; }
            public string Item_Name { get; set; }
            public string Quantity { get; set; }  // Adjust type if needed (e.g., int)
            public string Price { get; set; }     // Adjust type if needed (e.g., decimal)

            private string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Anoy;Integrated Security=True";

            public bool update(Item i)
            {
                bool success = false;
                SqlConnection sqc = new SqlConnection(connection);
                try
                {
                    string q = "UPDATE Items SET Item_Name=@Item_Name, Quantity=@Quantity, " +
                        "Price=@Price WHERE Item_Number=@Item_Number";

                    sqc.Open();
                    SqlCommand cmd = new SqlCommand(q, sqc);
                    cmd.Parameters.AddWithValue("@Item_Name", i.Item_Name);
                    cmd.Parameters.AddWithValue("@Item_Number", i.Item_Number);
                    cmd.Parameters.AddWithValue("@Quantity", i.Quantity);
                    cmd.Parameters.AddWithValue("@Price", i.Price);

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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Assuming the textboxes are for Item_Number, Item_Name, Quantity, Price
            if (string.IsNullOrEmpty(txt_updateNumber.Text) || string.IsNullOrEmpty(txt_updateName.Text) ||
                string.IsNullOrEmpty(txt_updateQn.Text) || string.IsNullOrEmpty(txt_updatePrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Item item = new Item();
            item.Item_Number = txt_updateNumber.Text;
            item.Item_Name = txt_updateName.Text;
            item.Quantity = txt_updateQn.Text;  // Assuming Quantity is a string; adjust if it's int
            item.Price = txt_updatePrice.Text;  // Assuming Price is a string; adjust if it's decimal

            if (item.update(item))
            {
                MessageBox.Show("Item updated successfully.");
                // Optionally, clear the textboxes
                txt_updateNumber.Clear();
                txt_updateName.Clear();
                txt_updateQn.Clear();
                txt_updatePrice.Clear();
            }
            else
            {
                MessageBox.Show("Error updating item. Please try again.");
            }
        }

        private void txt_updateNumber_TextChanged(object sender, EventArgs e)
        {}

        private void txt_updateName_TextChanged(object sender, EventArgs e){}
        private void txt_updateQn_TextChanged(object sender, EventArgs e){}
        private void txt_updatePrice_TextChanged(object sender, EventArgs e){}

        private void btn_back_Click(object sender, EventArgs e)
        {
            grochery g = new grochery();
            g.Show();
            this.Hide();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            grochery g = new grochery();
            g.Show();
            this.Hide();
        }
    }
}