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
namespace Mcdonalds_project
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Guestorder22 f2 = new Guestorder22();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mcdonalds;";
            //string query = "INSERT INTO signup(`city`, `area`, `streetno`, `buildingno`,`floorno`,`roomno`,`email`,`password`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "')";


            //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            //commandDatabase.CommandTimeout = 60;

            //if (textBox1.Text == "")
            //{
            //    MessageBox.Show("Please enter your city");
            //}
            //else
            //{
            //    if (textBox2.Text == "")
            //    {
            //        MessageBox.Show("Please enter your area name");
            //    }
            //    else
            //    {
            //        if (textBox3.Text == "")
            //        {
            //            MessageBox.Show("Please enter your street number ");
            //        }
            //        else
            //        {
            //            if (textBox4.Text == "")
            //            {
            //                MessageBox.Show("Please enter your building no  ");
            //            }
            //            else
            //            {

            //                if (textBox5.Text == "")
            //                {
            //                    MessageBox.Show("Please enter your floor number ");
            //                }
            //                else
            //                {
            //                    if (textBox6.Text == "")
            //                    {
            //                        MessageBox.Show("Please enter your room number ");
            //                    }
            //                    else
            //                    {
            //                        if (textBox7.Text == "")
            //                        {
            //                            MessageBox.Show("Please enter your email");
            //                        }
            //                        else
            //                        {
            //                            if (textBox8.Text == "")
            //                            {
            //                                MessageBox.Show("Please enter your password");
            //                            }
            //                            else
            //                            {
            //                                if (textBox8.Text != textBox9.Text)
            //                                {
            //                                    MessageBox.Show("Password is not matched");

            //                                }
            //                                else
            //                                {
            //                                    try
            //                                    {
            //                                        databaseConnection.Open();
            //                                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
            //                                        MessageBox.Show("Congratulations!!!  Registered Successfully ");
            //                                        Signin home = new Signin();
            //                                        home.Show();
            //                                        this.Hide();

            //                                        databaseConnection.Close();
            //                                    }
            //                                    catch (Exception ex)
            //                                    {
            //                                        // Show any error message.
            //                                        MessageBox.Show(ex.Message);
            //                                    }

            //                                }
            //                            }


            //                        }



            //                    }



                               
            //                }


            //            }
            //        }
            //    }
            //}
            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            //textBox5.Text = "";
            //textBox6.Text = "";
            //textBox7.Text = "";
            //textBox8.Text = "";
           
        }

        private void label14_Click(object sender, EventArgs e)
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

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();

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

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Process.Start("https://mcdonalds.com.pk/privacy-policy/");
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Process.Start("https://mcdonalds.com.pk/privacy-policy/");

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start("https://m.facebook.com/login/?refsrc=deprecated");

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/accounts/login/");

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
   
            Process.Start("https://www.youtube.com/");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mcdonalds;";
            string query = "INSERT INTO signup(`city`, `area`, `streetno`, `buildingno`,`floorno`,`roomno`,`email`,`password`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "')";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your city");
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please enter your area name");
                }
                else
                {
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Please enter your street number ");
                    }
                    else
                    {
                        if (textBox4.Text == "")
                        {
                            MessageBox.Show("Please enter your building no  ");
                        }
                        else
                        {

                            if (textBox5.Text == "")
                            {
                                MessageBox.Show("Please enter your floor number ");
                            }
                            else
                            {
                                if (textBox6.Text == "")
                                {
                                    MessageBox.Show("Please enter your room number ");
                                }
                                else
                                {
                                    if (textBox7.Text == "")
                                    {
                                        MessageBox.Show("Please enter your email");
                                    }
                                    else
                                    {
                                        if (textBox8.Text == "")
                                        {
                                            MessageBox.Show("Please enter your password");
                                        }
                                        else
                                        {
                                            if (textBox8.Text != textBox9.Text)
                                            {
                                                MessageBox.Show("Password is not matched");

                                            }
                                            else
                                            {
                                                try
                                                {
                                                    databaseConnection.Open();
                                                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                                                    MessageBox.Show("Congratulations!!!  Registered Successfully ");
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
                    }
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";


        }
    }
}
