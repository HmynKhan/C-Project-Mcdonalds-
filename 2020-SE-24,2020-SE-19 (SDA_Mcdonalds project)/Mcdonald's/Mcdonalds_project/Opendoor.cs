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
using MySql.Data.MySqlClient;
namespace Mcdonalds_project
{
    public partial class Opendoor : Form
    {
        public Opendoor()
        {
            InitializeComponent();
        }

        private void pictureBox55_Click(object sender, EventArgs e)
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

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Process.Start("https://m.facebook.com/login/?refsrc=deprecated");

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/accounts/login/");

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/login");

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.mcdelivery.com.pk/pk/support-privacy.html?staticLinkId=3&locale=en");

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mcdelivery.com.pk/pk/support-tnc.html?staticLinkId=2&locale=en");

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.apple.com/app-store/");

        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            Process.Start("https://play.google.com/store/apps");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mcdonalds;";
            string query = "INSERT INTO opendoor(`firstname`, `lastname`, `email`, `restaurant`, `visitdate`,`contact`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker1.Value.Date.ToString() + "', '" + textBox6.Text + "')";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your first name");
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please enter your last name");
                }
                else
                {
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Please enter your email");
                    }
                    else
                    {
                        if (textBox4.Text == "")
                        {
                            MessageBox.Show("Please enter your restaurant location");
                        }
                        else
                        {

                            if (dateTimePicker1.Text == "")
                            {
                                MessageBox.Show("Please enter your visit date");
                            }
                            else
                            {
                                if (textBox6.Text == "")
                                {
                                    MessageBox.Show("Please enter your contact");
                                }
                                else
                                {

                                    try
                                    {
                                        databaseConnection.Open();
                                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                                        MessageBox.Show("Congratulations!!!  thank you for message has sent to you.");
                                        Signin home = new Signin();
                                        home.Show();
                                        this.Hide();

                                        databaseConnection.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        // Show any error message.
                                        MessageBox.Show(ex.Message);
                                    }

                                }







                            }



                        }

                    }
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";

         
        }

        private void label13_Click(object sender, EventArgs e)
        {
            order1 f = new order1();
            f.Show();
            this.Hide();
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {


        }
    }
}




                           