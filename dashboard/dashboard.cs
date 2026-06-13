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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
        }

        private void bt_grochery(object sender, EventArgs e)
        {
            grochery gb = new grochery();
            gb.Show();
            this.Hide();
        }
        private void bt_snacks_Click(object sender, EventArgs e)
        {
            snacks db1 = new snacks();
            db1.Show();
            this.Hide();

        }
        private void bt_fruits_Click(object sender, EventArgs e)
        {
            fruits db5 = new fruits();
            db5.Show();
            this.Hide();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Managers m = new Managers ();
            m.Show();
            this.Hide();
        }
    }
}
