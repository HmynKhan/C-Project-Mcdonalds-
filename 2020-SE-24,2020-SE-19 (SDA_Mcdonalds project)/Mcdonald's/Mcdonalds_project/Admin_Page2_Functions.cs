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
    public partial class Admin_Page2_Functions : Form
    {
        public Admin_Page2_Functions()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ourmenu F = new Ourmenu();
            F.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Page3_Sales s1 = new Admin_Page3_Sales();
            s1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ourmenu F = new Ourmenu();
            F.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminguest f1 = new Adminguest();
            f1.Show();
            this.Hide();
        }
    }
}
