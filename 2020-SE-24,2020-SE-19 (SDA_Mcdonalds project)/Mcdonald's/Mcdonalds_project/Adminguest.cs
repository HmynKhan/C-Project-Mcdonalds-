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
    public partial class Adminguest : Form
    {
        public Adminguest()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Last Name";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "Resturant";
            dataGridView1.Columns[4].Name = "Visit Date";
            dataGridView1.Columns[5].Name = "Contact";

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=mcdonalds;");
            MySqlCommand command;
            MySqlDataReader mdr;
            connection.Open();
            string selectQuery = "SELECT * FROM opendoor";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            while (mdr.Read())
            {
                string[] row = new string[] { mdr.GetString(0), mdr.GetString(1), mdr.GetString(2), mdr.GetString(3), mdr.GetString(4), mdr.GetString(5) };
                dataGridView1.Rows.Add(row);
            }

            connection.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ourmenu F = new Ourmenu();
            F.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Page2_Functions F = new Admin_Page2_Functions();
            F.Show();
            this.Hide();
        }
    }
}
