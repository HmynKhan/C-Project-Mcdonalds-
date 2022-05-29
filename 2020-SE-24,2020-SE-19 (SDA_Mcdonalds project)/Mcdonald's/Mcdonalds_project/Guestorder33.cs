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
    public partial class Guestorder33 : Form
    {
        public Guestorder33()
        {
            InitializeComponent();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
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

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtube.com/");

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/accounts/login/");

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start("https://m.facebook.com/login/?refsrc=deprecated");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }
    }
}
