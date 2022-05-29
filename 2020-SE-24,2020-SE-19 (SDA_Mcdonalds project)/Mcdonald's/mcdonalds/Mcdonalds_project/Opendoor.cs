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
    public partial class Opendoor : Form
    {
        public Opendoor()
        {
            InitializeComponent();
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            Homepage f2 = new Homepage();
            f2.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Ourmenu f2 = new Ourmenu();
            f2.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Opendoor f2 = new Opendoor();
            f2.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Signin f2 = new Signin();
            f2.Show();
            this.Hide();

        }
    }
}
