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
    public partial class Ourmenu : Form
    {
        string email;

        public void getemail(string e)
        { email = e; }
        public Ourmenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            happy_menu f2 = new happy_menu();
            f2.Show();
            this.Hide();
            f2.getemail(email);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            happy_meals f2 = new happy_meals();
            f2.Show();
            this.Hide();
            f2.getemail(email);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Value_meals f2 = new Value_meals();
            f2.Show();
            this.Hide();
            f2.getemail(email);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Extra_value_meals f2 = new Extra_value_meals();
            f2.Show();
            this.Hide();
            f2.getemail(email);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Page2_Functions f2 = new Admin_Page2_Functions();
            f2.Show();
            this.Hide();

        }
    }
}
