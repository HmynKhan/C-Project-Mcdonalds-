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
    public partial class Value_meals : Form
    {
        string email;

        public void getemail(string e)
        { email = e; }
        public Value_meals()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Extra_value_meals f2 = new Extra_value_meals();
            f2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            happy_meals f2 = new happy_meals();
            f2.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            happy_menu f2 = new happy_menu();
            f2.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Value_meals f2 = new Value_meals();
            f2.Show();
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Deal 4");
            f2.getprice(" 300");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Deal 2");
            f2.getprice(" 550");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Deal 1");
            f2.getprice(" 900");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Deal 3");
            f2.getprice("1200");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
