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
    public partial class stationery : Form
    {
        public stationery()
        {
            InitializeComponent();
        }

        private void stationery_Load(object sender, EventArgs e)
        {

        }

        private void bt_back_stationery_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
