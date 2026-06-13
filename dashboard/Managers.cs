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
    public partial class Managers : Form
    {
        public Managers()
        {
            InitializeComponent();
        }

        private void btn_stuff_Click(object sender, EventArgs e)
        {
            stuff s = new stuff();
            s.Show();
            this.Hide();
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            Dashboard D1 = new Dashboard();
            D1.Show();
            this.Hide();
        }

        private void exit_managers_Click(object sender, EventArgs e)
        {
            ManagerLogIn m = new ManagerLogIn();
            m.Show();
            this.Hide();
        }
    }
}
