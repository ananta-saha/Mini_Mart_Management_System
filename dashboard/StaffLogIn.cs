using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class StaffLogIn : Form
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=admindashboard;Integrated Security=True";

        public StaffLogIn()
        {
            InitializeComponent();
        }

        private void gofirststaff_Click(object sender, EventArgs e)
        {
            First zx = new First();
            zx.Show();
            this.Hide();
        }

        private void StaffLogIn_Load(object sender, EventArgs e)
        {

        }

        private void staffidtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffpasstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffnext_Click(object sender, EventArgs e)
        {
            string staffName = staffnametextbox.Text.Trim();
            string staffId = staffidtextbox.Text.Trim();
            string staffPassword = staffpasstextbox.Text.Trim();

            if (string.IsNullOrEmpty(staffName) || string.IsNullOrEmpty(staffId) || string.IsNullOrEmpty(staffPassword))
            {
                MessageBox.Show("Please fill all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValid = CheckStaffCredentials(staffName, staffId, staffPassword);

            if (isValid)
            {
                StaffInvent x = new StaffInvent();
                x.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong information. Please check your Staff Name, Staff ID, and Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckStaffCredentials(string name, string id, string password)
        {
            bool valid = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) FROM dbo.employee 
                                     WHERE name = @name AND employee_id = @id AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                            valid = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valid;
        }
    }
}
