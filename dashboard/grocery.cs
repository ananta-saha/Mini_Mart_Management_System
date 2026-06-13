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
    public partial class grochery : Form
    {
        public grochery()
        {
            InitializeComponent();
        }
        private void grocery_Load(object sender, EventArgs e)
        {
            this.itemsTableAdapter.Fill(this.anoyDataSet.Items);

        }
        private void bt_back_grochery_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add A = new Add();
            A.Show();
            this.Hide();
        }
    }
}
