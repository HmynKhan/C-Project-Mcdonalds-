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
    public partial class product1 : Form
    {
        public product1()
        {
            InitializeComponent();
        }

        string email;
        string meal;
        string price;
        public void getemail(string e)
        { email = e; }

        public void getmeal(string e)
        { meal = e; }

        public void getprice(string e)
        { price = e; }
        private void button5_Click(object sender, EventArgs e)
        {
            happy_meals f = new happy_meals();
            f.Show();
            f.getemail(email);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);

            int p = Convert.ToInt32(price);

            int a = p * n;

            Final_Order_List f1 = new Final_Order_List();
            f1.getemail(email);
            f1.getmeal(meal);
            f1.getprice(Convert.ToString(a));
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select your payment method");
            }
            else
            {
                MessageBox.Show("Payment link sent to your phone number and thanks for order food.");

                f1.Show();
                this.Hide();

            }
            
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=mcdonalds;");
            MySqlCommand command;
            MySqlDataReader mdr;
            connection.Open();
            string selectQuery = "Insert into `orders` (`Email`, `Name`, `Price`) Values ('" + email + "','" + meal + "', '" + price + "')";
            command = new MySqlCommand(selectQuery, connection);
            connection.Close();


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
