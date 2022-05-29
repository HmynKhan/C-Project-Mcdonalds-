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
    public partial class Extra_value_meals : Form
    {
        string email;

        public void getemail(string e)
        { email = e; }
        public Extra_value_meals()
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

        private void button10_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Extra_Meal 3");
            f2.getprice(" 650");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Extra-Meal 2 ");
            f2.getprice(" 700");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Extra_Meal 1");
            f2.getprice("1200");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            product1 f2 = new product1();
            f2.Show();
            this.Hide();
            f2.getemail(email);
            f2.getmeal("Extra_Meal 4");
            f2.getprice("850");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }
    }
}
