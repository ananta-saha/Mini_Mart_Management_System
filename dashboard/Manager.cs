using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Stuff_List_Click(object sender, EventArgs e)
        {
            Stuff_List S = new Stuff_List();
            S.Show();
            this.Hide();
        }

        private void Inventory_list_Click(object sender, EventArgs e)
        {
            Inventory_List I = new Inventory_List();
            I.Show();
            this.Hide();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
