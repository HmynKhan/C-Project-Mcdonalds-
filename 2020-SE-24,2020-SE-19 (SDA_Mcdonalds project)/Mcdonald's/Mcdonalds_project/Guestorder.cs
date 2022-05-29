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
    public partial class Guestorder : Form
    {
        public Guestorder()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Ourmenu f2 = new Ourmenu();
            f2.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Myaccount1 f2 = new Myaccount1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;

            }
            else if (pictureBox20.Visible == true)
            {
                pictureBox20.Visible = false;
                pictureBox25.Visible = true;

            }
            else if (pictureBox43.Visible == true)
            {
                pictureBox44.Visible = false;
                pictureBox12.Visible = true;

            }
            else if (pictureBox13.Visible == true)
            {
                pictureBox13.Visible = false;
                pictureBox20.Visible = true;

            }
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start("https://m.facebook.com/login/?refsrc=deprecated");


        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/accounts/login/");

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/");

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.mcdelivery.com.pk/m/pk/mobile/support-tnc.html?staticLinkId=2&locale=en");

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mcdelivery.com.pk/m/pk/mobile/support-privacy.html?staticLinkId=3&locale=en");

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mcdelivery.com.pk/m/pk/mobile/support-privacy.html?staticLinkId=3&locale=en");

        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guestorder22 f2 = new Guestorder22();
            f2.Show();
            this.Hide();

        }
    }
}
