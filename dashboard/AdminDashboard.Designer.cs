using System;
using System.Drawing;
using System.Windows.Forms;

namespace dashboard
{
    partial class AdminDashboard
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();

            // ID and Password
            txtID = CreateTextBox("ID", 20);
            txtPassword = CreateTextBox("Password", 50);

            txtName = CreateTextBox("Name", 80);
            txtEmail = CreateTextBox("Email", 140);
            txtContact = CreateTextBox("Contact Number", 200);
            txtAddress = CreateTextBox("Current Address", 260);

            joinDate = new DateTimePicker() { Location = new Point(250, 320), Width = 220 };
            this.Controls.Add(new Label() { Text = "Join Date", Location = new Point(50, 320), AutoSize = true });
            this.Controls.Add(joinDate);

            txtSearch = new TextBox() { Location = new Point(750, 18), Width = 300 };
            txtSearch.TextChanged += TxtSearch_TextChanged;
            this.Controls.Add(txtSearch);

            btnAdd = CreateButton("Add Employee", 380, AddEmployee);
            btnDelete = CreateButton("Delete Employee", 440, DeleteEmployee);
            btnPromote = CreateButton("Promote Employee", 500, PromoteEmployee);
            btnAddAdmin = CreateButton("Add New Admin", 560, AddAdmin);
            btnUpdate = CreateButton("Update", 620, UpdateEmployee);
            btnShowData = CreateButton("Show Data", 680, ShowData);
            btnShowInventory = CreateButton("Show Inventory", 740, ShowInventory);

            // ===== Back button =====
            btnBack = CreateButton("Back",750,750, BackToLogin);

            dgvEmployees = new DataGridView()
            {
                Location = new Point(500, 60),
                Size = new Size(850, 650),
                ColumnCount = 8,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            dgvEmployees.Columns[0].Name = "ID";
            dgvEmployees.Columns[1].Name = "Password";
            dgvEmployees.Columns[2].Name = "Name";
            dgvEmployees.Columns[3].Name = "Email";
            dgvEmployees.Columns[4].Name = "Role";
            dgvEmployees.Columns[5].Name = "Contact";
            dgvEmployees.Columns[6].Name = "Address";
            dgvEmployees.Columns[7].Name = "Join Date";

            dgvEmployees.CellClick += DgvEmployees_CellClick;
            dgvEmployees.CellFormatting += DgvEmployees_CellFormatting;

            this.Controls.Add(dgvEmployees);

            this.ClientSize = new Size(1382, 803);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += AdminDashboard_Load;

            this.ResumeLayout(false);
        }

        private TextBox CreateTextBox(string text, int top)
        {
            Label lbl = new Label()
            {
                Text = text,
                Location = new Point(50, top),
                AutoSize = true
            };
            this.Controls.Add(lbl);

            TextBox txt = new TextBox()
            {
                Location = new Point(250, top),
                Width = 220
            };
            this.Controls.Add(txt);

            return txt;
        }
        private Button CreateButton(string text, int x, int y, EventHandler handler)
        {
            Button btn = new Button()
            {
                Text = text,
                Location = new Point(x, y),
                Width = 200,
                Height = 35
            };
            btn.Click += handler;
            this.Controls.Add(btn);
            return btn;
        }


        private Button CreateButton(string text, int top, EventHandler handler)
        {
            Button btn = new Button()
            {
                Text = text,
                Location = new Point(50, top),
                Width = 200,
                Height = 35
            };
            btn.Click += handler;
            this.Controls.Add(btn);
            return btn;
        }
    }
}
