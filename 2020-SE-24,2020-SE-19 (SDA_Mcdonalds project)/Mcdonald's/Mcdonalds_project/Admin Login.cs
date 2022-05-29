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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox29.Visible == true)
            {
                pictureBox29.Visible = false;
                pictureBox25.Visible = true;

            }
            else if (pictureBox25.Visible == true)
            {
                pictureBox25.Visible = false;
                pictureBox22.Visible = true;

            }
            else if (pictureBox22.Visible == true)
            {
                pictureBox22.Visible = false;
                pictureBox3.Visible = true;

            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox29.Visible = true;

            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=mcdonalds;");
            MySqlCommand command;
            MySqlDataReader mdr;
            connection.Open();
            string selectQuery = "SELECT * FROM  `admin login` WHERE email = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                // MessageBox.Show("Login Successful!");
                Admin_Page2_Functions f1 = new Admin_Page2_Functions();
                f1.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("Your enter data is wrong .Please Try again");
                textBox1.Clear();
                textBox2.Clear();

            }

            connection.Close();

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter Email and Password", "Error");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            order1 f2 = new order1();
            f2.Show();
            this.Hide();

        }
    }
}
