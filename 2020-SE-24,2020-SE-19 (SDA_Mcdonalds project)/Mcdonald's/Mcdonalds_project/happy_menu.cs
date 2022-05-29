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
    public partial class happy_menu : Form
    {
        string email;

        public void getemail(string e)
        { email = e; }
        public happy_menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Extra_value_meals f = new Extra_value_meals();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            happy_meals f = new happy_meals();
            f.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            happy_menu f = new happy_menu();
            f.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Value_meals f = new Value_meals();
            f.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Ourmenu f = new Ourmenu();
            f.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Myaccount1 f = new Myaccount1();
            f.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Support f = new Support();
            f.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Zest Burger");
            f2.getprice(" 400");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Choclate Ice Cream");
            f2.getprice(" 400");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Choclate Shake");
            f2.getprice("539");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Mango Shake");
            f2.getprice("350");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }
    }
}
