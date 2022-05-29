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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Signin s = new Signin();
            s.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Opendoor f2 = new Opendoor();
            f2.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Homepage f2 = new Homepage();
            f2.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Ourmenu f2 = new Ourmenu();
            f2.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Signin f2 = new Signin();
            f2.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox55.Visible = true;

            }
            else if (pictureBox54.Visible == true)
            {
                pictureBox54.Visible = false;
                pictureBox55.Visible = true;

            }
            else if (pictureBox55.Visible == true)
            {
                pictureBox55.Visible = false;
                pictureBox56.Visible = true;

            }
            else if (pictureBox56.Visible == true)
            {
                pictureBox56.Visible = false;
                pictureBox9.Visible = true;

            }
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Opendoor f2 = new Opendoor();
            f2.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ourmenu f2 = new Ourmenu();
            f2.Show();
            this.Hide();

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Process.Start("https://m.facebook.com/login/?refsrc=deprecated");
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/login");

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/accounts/login/");

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
       
            Process.Start("https://www.apple.com/app-store/");

        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            Process.Start("https://play.google.com/store/apps");

         

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
        
            Process.Start("https://www.mcdelivery.com.pk/m/pk/mobile/support-tnc.html?staticLinkId=2&locale=en");

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mcdelivery.com.pk/m/pk/mobile/support-privacy.html?staticLinkId=3&locale=en");

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mcdelivery.com.pk/m/pk/mobile/support-faq.html?staticLinkId=4&locale=en");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Admin_Login f2 = new Admin_Login();
            f2.Show();
            this.Hide();

        }
    }
}
