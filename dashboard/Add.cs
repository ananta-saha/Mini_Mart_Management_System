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
    public partial class Add : Form
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Anoy;Integrated Security=True";
        public Add()
        {
            InitializeComponent();
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqconn = new SqlConnection(connectionString);
                sqconn.Open();

                SqlCommand sqc = new SqlCommand("INSERT INTO Items (Item_Number, Item_Name, Quantity, Price) VALUES (@Item_Number, @Item_Name, @Quantity, @Price)", sqconn);
                sqc.Parameters.AddWithValue("@Item_Number", Convert.ToInt32(textBox1.Text));
                sqc.Parameters.AddWithValue("@Item_Name", textBox2.Text);
                sqc.Parameters.AddWithValue("@Quantity", Convert.ToInt32(textBox3.Text));
                sqc.Parameters.AddWithValue("@Price", Convert.ToDecimal(textBox4.Text));
                sqc.ExecuteNonQuery();
                sqconn.Close();
                MessageBox.Show("Item Added Successfully!");
                ClearFields(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nEnter Valid Info");
            }
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            grochery g = new grochery();
            g.Show();
            this.Hide();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}