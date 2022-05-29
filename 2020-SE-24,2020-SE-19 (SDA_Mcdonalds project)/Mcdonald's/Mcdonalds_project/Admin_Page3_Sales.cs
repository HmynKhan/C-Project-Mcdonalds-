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
    public partial class Admin_Page3_Sales : Form
    {
        int t_sales = 0;
        public Admin_Page3_Sales()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "User Email";
            dataGridView1.Columns[1].Name = "Meal Name";
            dataGridView1.Columns[2].Name = "Meal Price";
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=mcdonalds;");
            MySqlCommand command;
            MySqlDataReader mdr;
            connection.Open();
            string selectQuery = "SELECT * FROM orders";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            while (mdr.Read())
            {
                string[] row = new string[] { mdr.GetString(0),mdr.GetString(1),mdr.GetString(2) };
                dataGridView1.Rows.Add(row);
                t_sales += Convert.ToInt32(mdr.GetString(2));
            }
            textBox1.Text = Convert.ToString(t_sales);
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ourmenu F = new Ourmenu();
            F.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Page2_Functions F = new Admin_Page2_Functions();
            F.Show();
            this.Hide();

        }
    }
}
