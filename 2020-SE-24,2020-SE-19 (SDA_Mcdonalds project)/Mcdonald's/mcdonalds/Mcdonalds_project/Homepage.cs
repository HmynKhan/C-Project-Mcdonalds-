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
    }
}
