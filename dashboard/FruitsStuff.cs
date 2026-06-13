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
    public partial class FruitsStuff : Form
    {
        public FruitsStuff()
        {
            InitializeComponent();
        }

        private void BtnFruitsStuff_Click(object sender, EventArgs e)
        {
            StaffInvent si = new StaffInvent();
            si.Show();
            this.Hide();
        }

        private void FruitsStuff_Load(object sender, EventArgs e)
        {
            this.itemsTableAdapter.Fill(this.anoy2DataSet2.Items);

        }
    }
}
