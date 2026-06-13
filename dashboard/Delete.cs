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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dltItem.Text))
            {
                MessageBox.Show("Please enter an Item Number to delete.");
                return;
            }

            Item item = new Item();
            item.Item_Number = txt_dltItem.Text;

            if (item.delete(item))
            {
                MessageBox.Show("Item deleted successfully.");
                txt_dltItem.Clear();
            }
            else
            {
                MessageBox.Show("Error deleting item. Please try again.");
            }
        }

        public class Item
        {
            public string Item_Number { get; set; }

            private string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Anoy;Integrated Security=True";
            public bool delete(Item i)
            {
                bool success = false;
                SqlConnection sqc = new SqlConnection(connection);
                try
                {
                    string q = "DELETE FROM Items WHERE Item_Number = @Item_Number";  

                    sqc.Open();
                    SqlCommand cmd = new SqlCommand(q, sqc);
                    cmd.Parameters.AddWithValue("@Item_Number", i.Item_Number);

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            grochery g = new grochery();
            g.Show();
            this.Hide();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}