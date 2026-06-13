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
    public partial class UpdateSnacks : Form
    {
        public UpdateSnacks()
        {
            InitializeComponent();
        }

        private void Item_Number_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_updateNumber_snacks.Text) || string.IsNullOrEmpty(txt_updateName_snacks.Text) ||
                string.IsNullOrEmpty(txt_updateQn_snakcs.Text) || string.IsNullOrEmpty(txt_updatePrice_snakcs.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Item item = new Item();
            item.Item_Number = txt_updateNumber_snacks.Text;
            item.Item_Name = txt_updateName_snacks.Text;
            item.Quantity = txt_updateQn_snakcs.Text;  
            item.Price = txt_updatePrice_snakcs.Text;  

            if (item.update(item))
            {
                MessageBox.Show("Item updated successfully.");
                txt_updateNumber_snacks.Clear();
                txt_updateName_snacks.Clear();
                txt_updateQn_snakcs.Clear();
                txt_updatePrice_snakcs.Clear();
            }
            else
            {
                MessageBox.Show("Error updating item. Please try again.");
            }
        }

        private void txt_updatePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void txt_updateQn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_Click(object sender, EventArgs e)
        {

        }

        private void txt_updateName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item_Name_Click(object sender, EventArgs e)
        {

        }

        private void txt_updateNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            snacks s = new snacks();
            s.Show();
            this.Hide();
        }

        private void UpdateSnacks_Load(object sender, EventArgs e)
        {

        }

        public class Item
        {
            public string Item_Number { get; set; }
            public string Item_Name { get; set; }
            public string Quantity { get; set; }  
            public string Price { get; set; }     

            private string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Anoy1;Integrated Security=True";

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
    }
}