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
using System.Diagnostics;
using System.Threading;

namespace Mcdonalds_project
{
    public partial class Signin : Form
    {
       // public Loadingbar2 Loadingbar2 { get; private set; }

        public Signin()
        {
            InitializeComponent();
        }

       /* void loadbutton()
        {
            for(int i=0;i<=499;i++)
            {
                Thread.Sleep(10);
            }
        }*/
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
            /*loadingbar f2 = new loadingbar();
            f2.Show();
            this.Hide();

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
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*loadingbar f2 = new loadingbar();
            f2.Show();
            this.Hide();

            Signup f12 = new Signup();
            f2.Show();
            this.Hide();*/

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

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Signin f2 = new Signin();
            f2.Show();
            this.Hide();

        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Myaccount1 f2 = new Myaccount1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Ourmenu f2 = new Ourmenu();
            f2.Show();
            this.Hide();

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
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

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/");

        }

        private void pictureBox27_Click_1(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            Process.Start("https://mcdonalds.com.pk/terms-and-conditions/");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*using (Loadingbar2 f = new Loadingbar2(loadbutton))
            {
                f.ShowDialog(this);
            }*/

            /*loadingbar f2 = new loadingbar();
            f2.Show();
            this.Hide();*/

           

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your E-mail");
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please enter your Password");
                }
                else
                {
                 

                    try
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
                            Ourmenu m = new Ourmenu();
                            m.Show();
                            m.getemail(textBox1.Text);
                        }
                        else
                        {

                            MessageBox.Show("Your not registered please first register and then sign-in.");
                            Signup home = new Signup();
                            home.Show();
                            this.Hide();

                        }

                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
                textBox1.Text = "";
                textBox2.Text = "";
            }
              /* MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=mcdonalds;");
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
                Ourmenu m = new Ourmenu();
                m.Show();
                m.getemail(textBox1.Text);
            }
            else
            {

                MessageBox.Show("Your not registered please first register and then sign-in.");
                Signup home = new Signup();
                home.Show();
                this.Hide();

            }

            connection.Close();*/

          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*loadingbar f2 = new loadingbar();
            f2.Show();
            this.Hide();*/

            Signup f12 = new Signup();
            f12.Show();
            this.Hide();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
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

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Login f12 = new Admin_Login();
            f12.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Guestorder f12 = new Guestorder();
            f12.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 f12 = new Form1();
            f12.Show();
            this.Hide();

        }
    }
}
