using System;
using System.Data;
using System.Windows.Forms;

namespace dashboard
{
    public partial class ManagerLogIn : Form
    {
        private DataAccess da;

        public ManagerLogIn()
        {
            InitializeComponent();
            da = new DataAccess("admindashboard");
        }

        private void gofirstmanager_Click(object sender, EventArgs e)
        {
            First xc = new First();
            xc.Show();
            this.Hide();
        }

        private void managernext_Click(object sender, EventArgs e)
        {
            string id = manageridtextbox.Text.Trim();
            string name = managernametextbox.Text.Trim();
            string password = managerpasstextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }
            string sql = $"SELECT * FROM dbo.employee WHERE employee_id = {id} AND name = '{name}' AND password = '{password}' AND role = 'Employee'";

            try
            {
                DataTable dt = da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                  
                    Managers m = new Managers();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message);
            }
        }

        private void manageridtextbox_TextChanged(object sender, EventArgs e) { }

        private void managernametextbox_TextChanged(object sender, EventArgs e) { }

        private void managerpasstextbox_TextChanged(object sender, EventArgs e) { }

        private void managername_Click(object sender, EventArgs e) { }
    }
}
