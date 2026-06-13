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
    public partial class StaffInvent : Form
    {
        public StaffInvent()
        {
            InitializeComponent();
        }

        private void btn_Backstuff_Click(object sender, EventArgs e)
        {
            StaffLogIn sx = new StaffLogIn();
            sx.Show();
            this.Hide();
        }

        private void btnFruitsStuff_Click(object sender, EventArgs e)
        {
            FruitsStuff sd = new FruitsStuff();
            sd.Show();
            this.Hide();
        }

        private void btnStuffSnacks_Click(object sender, EventArgs e)
        {
            SnacksStuff sd = new SnacksStuff();
            sd.Show();
            this.Hide();
        }

        private void btnStuffHrocery_Click(object sender, EventArgs e)
        {
            GroceryStuff sd = new GroceryStuff();
            sd.Show();
            this.Hide();
        }
    }
}
