using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Mcdonalds_project
{
    public partial class Myaccountactivationpractice : Form
    {
        public Myaccountactivationpractice()
        {
            InitializeComponent();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start("https://m.facebook.com/login/?refsrc=deprecated");

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/accounts/login/");

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/");

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mcdelivery.com.pk/pk/support-tnc.html?staticLinkId=2&locale=en");

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mcdelivery.com.pk/pk/support-tnc.html?staticLinkId=2&locale=en");

        }
    }
}
