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
    public partial class GroceryStuff : Form
    {
        public GroceryStuff()
        {
            InitializeComponent();
        }

        private void GroceryStuff_Load(object sender, EventArgs e)
        {
            this.itemsTableAdapter.Fill(this.anoyDataSet2.Items);

        }

        private void backGroceryStuff_Click(object sender, EventArgs e)
        {
            StaffInvent sq = new StaffInvent();
            sq.Show();
            this.Hide();
        }
    }
}
