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
    public partial class order1 : Form
    {
        string email;

        public void getemail(string e)
        { email = e; }

        public order1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {

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

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Hot Fudge Sundae");
            f2.getprice("850");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Mcflurry Oreo");
            f2.getprice("650");

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Sundae Brownie");
            f2.getprice(" 539");

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Vanilla Cone");
            f2.getprice(" 500");

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Apple Pie");
            f2.getprice(" 350");

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("paratha Roll");
            f2.getprice(" 700");

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("McCrispy-Mayonnaise");
            f2.getprice(" 250");

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Chiken value sharebag");
            f2.getprice("2500");

        }
    }
}
