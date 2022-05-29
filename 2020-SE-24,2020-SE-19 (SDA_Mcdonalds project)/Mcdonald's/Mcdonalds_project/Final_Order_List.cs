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
    public partial class Final_Order_List : Form
    {
        public Final_Order_List()
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
        private void button2_Click(object sender, EventArgs e)
        {
            Ourmenu f1 = new Ourmenu();
            f1.Show();
            f1.getemail(email);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "User Email";
            dataGridView1.Columns[1].Name = "Meal Name";
            dataGridView1.Columns[2].Name = "Meal Price";

            string[] row = new string[] { email, meal, price };
            dataGridView1.Rows.Add(row);
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=mcdonalds;");
            MySqlCommand command;
            MySqlDataReader mdr;
            connection.Open();
            string selectQuery = "Insert into orders(Email,Name,Price) Values ('" + email + "','" + meal +"', '"+ price +"')";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                //MessageBox.Show("Login Successful!");
                //this.Hide();
                //Ourmenu m = new Ourmenu();
                //m.Show();
            }
            else
            {

                //MessageBox.Show("Your not registered please first register and then sign-in.");
                //Signup home = new Signup();
                //home.Show();
                //this.Hide();

            }

            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "User Email";
            dataGridView1.Columns[1].Name = "Meal Name";
            dataGridView1.Columns[2].Name = "Meal Price";

            string[] row = new string[] { email, meal, price };
            dataGridView1.Rows.Add(row);
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=mcdonalds;");
            MySqlCommand command;
            MySqlDataReader mdr;
            connection.Open();
            string selectQuery = "Insert into orders(Email,Name,Price) Values ('" + email + "','" + meal + "', '" + price + "')";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                //MessageBox.Show("Login Successful!");
                //this.Hide();
                //Ourmenu m = new Ourmenu();
                //m.Show();
            }
            else
            {

                //MessageBox.Show("Your not registered please first register and then sign-in.");
                //Signup home = new Signup();
                //home.Show();
                //this.Hide();

            }

            connection.Close();
        /*
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=mcdonalds;"); //open connection
            con.Open();
            dataGridView1.DataSource = null;
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from orders WHERE Email='"+ email + "' && Name='"+meal+"' && Price='"+price+"'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();*/

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Ourmenu f1 = new Ourmenu();
            f1.Show();
            f1.getemail(email);
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
