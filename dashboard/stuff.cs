using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class stuff : Form
    {
        private string connection =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=admindashboard;Integrated Security=True";

        public stuff()
        {
            InitializeComponent();
        }

        private void stuff_Load_1(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    string query = @"
                        SELECT 
                            ROW_NUMBER() OVER (ORDER BY e.employee_id) AS SL,
                            e.employee_id,
                            ISNULL(w.StaffShifts,'') AS StaffShift
                        FROM dbo.Employee e
                        LEFT JOIN dbo.Work w ON e.employee_id = w.StaffID
                        ORDER BY e.employee_id";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.Fill(dt);
                }

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.Name == "StaffID" && col.DisplayIndex > 1)
                    {
                        dataGridView1.Columns.Remove(col);
                        break;
                    }
                }

                if (dataGridView1.Columns.Contains("SL"))
                {
                    dataGridView1.Columns["SL"].HeaderText = "No";
                    dataGridView1.Columns["SL"].DisplayIndex = 0;
                    dataGridView1.Columns["SL"].Width = 60;
                }

                if (dataGridView1.Columns.Contains("employee_id"))
                {
                    dataGridView1.Columns["employee_id"].HeaderText = "Staff ID";
                    dataGridView1.Columns["employee_id"].DisplayIndex = 1;
                    dataGridView1.Columns["employee_id"].Visible = true;
                }

                if (dataGridView1.Columns.Contains("StaffShift"))
                {
                    dataGridView1.Columns["StaffShift"].HeaderText = "Shift";
                    dataGridView1.Columns["StaffShift"].DisplayIndex = 2;
                }

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox2.Text =
                    dataGridView1.SelectedRows[0].Cells["employee_id"].Value.ToString();

                textBox3.Text =
                    dataGridView1.SelectedRows[0].Cells["StaffShift"].Value.ToString();
            }
        }

        private void btn_Updatequantity_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text.Trim(), out int staffID))
            {
                MessageBox.Show("Invalid Staff ID");
                return;
            }

            string shift = textBox3.Text.Trim();
            if (shift == "")
            {
                MessageBox.Show("Enter shift");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string checkEmployee =
                    "SELECT COUNT(*) FROM dbo.Employee WHERE employee_id=@id";
                SqlCommand empCmd = new SqlCommand(checkEmployee, conn);
                empCmd.Parameters.AddWithValue("@id", staffID);

                if ((int)empCmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Staff ID does not exist in Employee table");
                    return;
                }

                string checkWork =
                    "SELECT COUNT(*) FROM dbo.Work WHERE StaffID=@id";
                SqlCommand workCmd = new SqlCommand(checkWork, conn);
                workCmd.Parameters.AddWithValue("@id", staffID);

                if ((int)workCmd.ExecuteScalar() > 0)
                {
                    string update =
                        "UPDATE dbo.Work SET StaffShifts=@s WHERE StaffID=@id";
                    SqlCommand cmd = new SqlCommand(update, conn);
                    cmd.Parameters.AddWithValue("@s", shift);
                    cmd.Parameters.AddWithValue("@id", staffID);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string insert =
                        "INSERT INTO dbo.Work (StaffID, StaffShifts) VALUES (@id,@s)";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@id", staffID);
                    cmd.Parameters.AddWithValue("@s", shift);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Shift Updated");
            LoadEmployeeData();
        }

        private void back_staff_Click(object sender, EventArgs e)
        {
            Managers m = new Managers();
            m.Show();
            this.Hide();
        }

        private void Staff_Shift_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void Item_Number_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void stuff_Load(object sender, EventArgs e) { }
    }
}
