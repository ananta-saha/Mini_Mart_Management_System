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
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void adminsignin_Click(object sender, EventArgs e)
        {
            AdminSignIn adminForm = new AdminSignIn();
            adminForm.Show();
            this.Hide();

            adminForm.FormClosed += (s, args) => this.Show();
        }

        private void First_Load(object sender, EventArgs e)
        {

        }

        private void managerbutton_Click(object sender, EventArgs e)
        {
            ManagerLogIn managerForm = new ManagerLogIn();
            managerForm.Show();
            this.Hide();

            managerForm.FormClosed += (s, args) => this.Show();
        }

        private void staffsign_Click(object sender, EventArgs e)
        {
            StaffLogIn staffForm = new StaffLogIn();
            staffForm.Show();
            this.Hide();

            staffForm.FormClosed += (s, args) => this.Show();
        }

        private void exitfirstbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
