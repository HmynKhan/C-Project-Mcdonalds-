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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (pictureBox59.Visible == true)
                {
                    pictureBox59.Visible = false;
                    pictureBox56.Visible = true;

                }
                else if (pictureBox56.Visible == true)
                {
                    pictureBox56.Visible = false;
                    pictureBox57.Visible = true;

                }
                else if (pictureBox57.Visible == true)
                {
                    pictureBox57.Visible = false;
                    pictureBox58.Visible = true;

                }
                else if (pictureBox58.Visible == true)
                {
                    pictureBox58.Visible = false;
                    pictureBox59.Visible = true;

                }
           

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Process.Start("https://m.facebook.com/login/?refsrc=deprecated");

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/login");

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/accounts/login/");

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mcdelivery.com.pk/m/pk/mobile/support-privacy.html?staticLinkId=3&locale=en");

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.mcdelivery.com.pk/m/pk/mobile/support-tnc.html?staticLinkId=2&locale=en");

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
        
            Process.Start("https://www.apple.com/app-store/");

        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            Process.Start("https://play.google.com/store/apps");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }
    }
}
