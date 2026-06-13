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
    public partial class DeleteFruits : Form
    {
        public DeleteFruits()
        {
            InitializeComponent();
        }

        private void btn_dlt_fruits_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dltItem_fruits.Text))
            {
                MessageBox.Show("Please enter an Item Number to delete.");
                return;
            }

            Fruit fruit = new Fruit();
            fruit.Item_Number = txt_dltItem_fruits.Text;

            if (fruit.delete(fruit))
            {
                MessageBox.Show("Fruit deleted successfully.");
                txt_dltItem_fruits.Clear();
            }
            else
            {
                MessageBox.Show("Error deleting fruit. Please try again.");
            }
        }

        public class Fruit
        {
            public string Item_Number { get; set; }

            private string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Anoy2;Integrated Security=True";
            public bool delete(Fruit f)
            {
                bool success = false;
                SqlConnection sqc = new SqlConnection(connection);
                try
                {
                    string q = "DELETE FROM Items WHERE Item_Number = @Item_Number";

                    sqc.Open();
                    SqlCommand cmd = new SqlCommand(q, sqc);
                    cmd.Parameters.AddWithValue("@Item_Number", f.Item_Number);

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

        private void btn_back_fruits_Click(object sender, EventArgs e)
        {
            fruits f2 = new fruits();
            f2.Show();
            this.Hide();
        }

        private void DeleteFruits_Load(object sender, EventArgs e)
        {

        }
    }
}