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
    public partial class fruits : Form
    {
        public fruits()
        {
            InitializeComponent();
        }

        private void fruits_Load(object sender, EventArgs e)
        {
            this.itemsTableAdapter.Fill(this.anoy2DataSet.Items);

        }

        private void bt_back_fruits_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Addfruits a1 = new Addfruits();
            a1.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteFruits f1 = new DeleteFruits();
            f1.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateFruits f3 = new UpdateFruits();
            f3.Show();
            this.Hide();
        }
    }
}
