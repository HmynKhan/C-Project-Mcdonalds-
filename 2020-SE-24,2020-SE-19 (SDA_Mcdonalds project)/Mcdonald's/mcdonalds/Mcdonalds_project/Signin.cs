using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Mcdonalds_project
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Signin f2 = new Signin();
            f2.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Support f2 = new Support();
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

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox22.Visible == true)
            {
                pictureBox22.Visible = false;
                pictureBox25.Visible = true;

            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox22.Visible = true;

            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=mcdonalds;");
            MySqlCommand command;
            MySqlDataReader mdr;
            connection.Open();
            string selectQuery = "SELECT * FROM  signup WHERE email = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
               // Paymentinfo home = new Paymentinfo();
                //home.Show();
               // this.Hide();
            }
            else
            {

                MessageBox.Show("Your not registered please first register and then sign-in.");
                Signup home = new Signup();
                home.Show();
                this.Hide();

            }

            connection.Close();

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter Email and Password", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup f2 = new Signup();
            f2.Show();
            this.Hide();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Signin f2 = new Signin();
            f2.Show();
            this.Hide();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Guestorder f2 = new Guestorder();
            f2.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Signin f2 = new Signin();
            f2.Show();
            this.Hide();

        }
    }
}
