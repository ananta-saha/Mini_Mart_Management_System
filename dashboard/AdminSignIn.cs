using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class AdminSignIn : Form
    {
        private DataAccess da;

        public AdminSignIn()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void AdminSignIn_Load(object sender, EventArgs e)
        {

        }

        private void gofirst_Click(object sender, EventArgs e)
        {
            First c = new First();
            c.Show();
            this.Hide();
        }

        private void adminnametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminidtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminpasstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextadmindash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(adminidtextbox.Text) || !int.TryParse(adminidtextbox.Text, out int adminId))
            {
                MessageBox.Show("Enter valid Information!");
                return;
            }

            string sql = $"SELECT * FROM admins WHERE admin_id = {adminId} AND admin_name = '{adminnametextbox.Text}' AND password = '{adminpasstextbox.Text}'";
            var dt = da.ExecuteQueryTable(sql);
            if (dt.Rows.Count > 0)
            {
                AdminDashboard ad = new AdminDashboard();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Admin login error");
            }
        }
    }
}