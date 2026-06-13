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
    public partial class SnacksStuff : Form
    {
        public SnacksStuff()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSnacksStuff_Click(object sender, EventArgs e)
        {
            StaffInvent sf = new StaffInvent();
            sf.Show();
            this.Hide();
        }

        private void SnacksStuff_Load(object sender, EventArgs e)
        {
            this.itemsTableAdapter.Fill(this.anoy1DataSet2.Items);

        }
    }
}
