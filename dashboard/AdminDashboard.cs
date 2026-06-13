using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace dashboard
{
    public partial class AdminDashboard : Form
    {
        private TextBox txtID, txtPassword, txtName, txtEmail, txtContact, txtAddress, txtSearch;
        private DateTimePicker joinDate;
        private DataGridView dgvEmployees;
        private Button btnAdd, btnDelete, btnPromote, btnAddAdmin, btnShowData, btnShowInventory, btnUpdate, btnBack;

        private DataAccess da;

        public AdminDashboard()
        {
            InitializeComponent();
            da = new DataAccess("admindashboard");
        }

        private void DgvEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.Value != null)
                dgvEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = e.Value.ToString();
        }

        private void DgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPassword.Text = dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dgvEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dgvEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtContact.Text = dgvEmployees.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAddress.Text = dgvEmployees.Rows[e.RowIndex].Cells[6].Value.ToString();
                joinDate.Value = DateTime.Parse(dgvEmployees.Rows[e.RowIndex].Cells[7].Value.ToString());
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ShowData(null, null);
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return false;
            }

            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Name must contain letters only!");
                return false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter valid email!");
                return false;
            }

            if (!Regex.IsMatch(txtContact.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Contact must be numbers only!");
                return false;
            }
            return true;
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string sql = $"INSERT INTO dbo.employee (password, name, email, contact, joinDate, role, address) " +
                         $"VALUES ('{txtPassword.Text}','{txtName.Text}','{txtEmail.Text}','{txtContact.Text}','{joinDate.Value:yyyy-MM-dd}','Employee','{txtAddress.Text}')";

            da.ExecuteUpdateQuery(sql);

            var dt = da.ExecuteQueryTable("SELECT MAX(employee_id) AS last_id FROM dbo.employee");
            txtID.Text = dt.Rows[0]["last_id"].ToString();

            MessageBox.Show("Employee Added Successfully!");
            ClearInputs();
            ShowData(null, null);
        }

        private void AddAdmin(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string sql = $"INSERT INTO dbo.employee (password, name, email, contact, joinDate, role, address) " +
                         $"VALUES ('{txtPassword.Text}','{txtName.Text}','{txtEmail.Text}','{txtContact.Text}','{joinDate.Value:yyyy-MM-dd}','Admin','{txtAddress.Text}')";

            da.ExecuteUpdateQuery(sql);

            var dt = da.ExecuteQueryTable("SELECT MAX(employee_id) AS last_id FROM dbo.employee");
            txtID.Text = dt.Rows[0]["last_id"].ToString();

            MessageBox.Show("New Admin Added!");
            ClearInputs();
            ShowData(null, null);
        }

        private void UpdateEmployee(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please select an employee to update.");
                return;
            }

            string sql = $"UPDATE dbo.employee SET password='{txtPassword.Text}', name='{txtName.Text}', contact='{txtContact.Text}', address='{txtAddress.Text}', joinDate='{joinDate.Value:yyyy-MM-dd}' WHERE employee_id={txtID.Text}";
            int rows = da.ExecuteUpdateQuery(sql);
            MessageBox.Show(rows > 0 ? "Updated Successfully!" : "Employee not found!");
            ShowData(null, null);
        }

        private void DeleteEmployee(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please select an employee to delete.");
                return;
            }

            string sql = $"DELETE FROM dbo.employee WHERE employee_id={txtID.Text}";
            int rows = da.ExecuteUpdateQuery(sql);
            MessageBox.Show(rows > 0 ? "Employee Deleted!" : "Employee not found!");
            ClearInputs();
            ShowData(null, null);
        }

        private void PromoteEmployee(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please select an employee to promote.");
                return;
            }

            string sql = $"UPDATE dbo.employee SET role='Admin' WHERE employee_id={txtID.Text}";
            int rows = da.ExecuteUpdateQuery(sql);
            MessageBox.Show(rows > 0 ? "Employee Promoted!" : "Employee not found!");
            ShowData(null, null);
        }

        private void ShowData(object sender, EventArgs e)
        {
            string sql = "SELECT employee_id, password, name, email, CASE WHEN role='Admin' THEN 'Admin' ELSE 'Employee' END AS Role, contact, address, joinDate FROM dbo.employee";
            var dt = da.ExecuteQueryTable(sql);

            dgvEmployees.Rows.Clear();
            foreach (DataRow r in dt.Rows)
                dgvEmployees.Rows.Add(
                    r["employee_id"],
                    r["password"],
                    r["name"],
                    r["email"],
                    r["Role"],
                    r["contact"],
                    r["address"],
                    Convert.ToDateTime(r["joinDate"]).ToShortDateString()
                );
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text;
            string sql = $"SELECT employee_id, password, name, email, CASE WHEN role='Admin' THEN 'Admin' ELSE 'Employee' END AS Role, contact, address, joinDate " +
                         $"FROM dbo.employee WHERE name LIKE '%{s}%' OR email LIKE '%{s}%' OR contact LIKE '%{s}%'";
            var dt = da.ExecuteQueryTable(sql);

            dgvEmployees.Rows.Clear();
            foreach (DataRow r in dt.Rows)
                dgvEmployees.Rows.Add(
                    r["employee_id"],
                    r["password"],
                    r["name"],
                    r["email"],
                    r["Role"],
                    r["contact"],
                    r["address"],
                    Convert.ToDateTime(r["joinDate"]).ToShortDateString()
                );
        }

        private void ShowInventory(object sender, EventArgs e)
        {
            MessageBox.Show("Inventory page will be connected later.");
        }

        private void ClearInputs()
        {
            txtPassword.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtAddress.Clear();
        }
        private void BackToLogin(object sender, EventArgs e)
        {
            AdminSignIn login = new AdminSignIn();
            login.Show();
            this.Close();
        }
    }
}
