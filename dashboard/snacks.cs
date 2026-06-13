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
    public partial class snacks : Form
    {
        public snacks()
        {
            InitializeComponent();
        }

        private void snacks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anoy1DataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.anoy1DataSet.Items);

        }

        private void bt_back_snacks_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addSnacks Snacks = new addSnacks();
            Snacks.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deletesnacks s2 = new deletesnacks();
            s2.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateSnacks s3 = new UpdateSnacks();
            s3.Show();
            this.Hide();
        }
    }
}
