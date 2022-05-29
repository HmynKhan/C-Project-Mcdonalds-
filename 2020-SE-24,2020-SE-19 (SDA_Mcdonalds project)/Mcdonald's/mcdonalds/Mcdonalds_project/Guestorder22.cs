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
    public partial class Guestorder22 : Form
    {
        public Guestorder22()
        {
            InitializeComponent();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox16.Visible = true;

            }
            else if (pictureBox20.Visible == true)
            {
                pictureBox21.Visible = false;
                pictureBox24.Visible = true;

            }
            else if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox16.Visible = true;

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Guestorder22 f2 = new Guestorder22();
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
            Myaccount1 f2 = new Myaccount1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }
    }
}
