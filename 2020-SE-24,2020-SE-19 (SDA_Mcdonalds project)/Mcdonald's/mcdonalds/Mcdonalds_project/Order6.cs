using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mcdonalds_project
{
    public partial class Order6 : Form
    {
        public Order6()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            order1 f = new order1();
            f.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            order1 f = new order1();
            f.Show();
            this.Hide();

        }
    }
}
