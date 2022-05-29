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
            if (pictureBox24.Visible == true)
            {
                pictureBox24.Visible = false;
                pictureBox21.Visible = true;

            }
            else if (pictureBox21.Visible == true)
            {
                pictureBox21.Visible = false;
                pictureBox20.Visible = true;

            }
            else if (pictureBox20.Visible == true)
            {
                pictureBox20.Visible = false;
                pictureBox16.Visible = true;

            }
            else if (pictureBox16.Visible == true)
            {
                pictureBox16.Visible = false;
                pictureBox12.Visible = true;

            }
            else if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox24.Visible = true;

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
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
            Process.Start("https://youtube.com/");

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guestorder33 f2 = new Guestorder33();
            f2.Show();
            this.Hide();

        }

        private void Guestorder22_Load(object sender, EventArgs e)
        {

        }
    }
}
