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
using System.Web;
using System.Net.Mail;
namespace Mcdonalds_project
{
    public partial class Myaccount1 : Form
    {
        public Myaccount1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Myaccount1 f2 = new Myaccount1();
            f2.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Myaccountactivationpractice f2 = new Myaccountactivationpractice();
            f2.Show();
            this.Hide();

        }

        private void pictureBox27_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Ourmenu f2 = new Ourmenu();
            f2.Show();
            this.Hide();

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Myaccount1 f2 = new Myaccount1();
            f2.Show();
            this.Hide();

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void pictureBox27_Click_1(object sender, EventArgs e)
        {
            Support f2 = new Support();
            f2.Show();
            this.Hide();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(100,34,76,12);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start("https://m.facebook.com/login/?refsrc=deprecated");

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/accounts/login/");

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/");

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D");

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.mcdelivery.com.pk/pk/support-tnc.html?staticLinkId=2&locale=en");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(textBox2.Text);
                    mail.To.Add("azamkashif76@gmail.com");
                    mail.Subject = "Bookme";
                    mail.Body = "<h1>Thank you for using the bookme.Stay safe and Stay Blessed</h1>";
                    mail.IsBodyHtml = true;
                    using (SmtpClient setp = new SmtpClient("setp.gmail.com", 587))
                    {
                        setp.Credentials = new System.Net.NetworkCredential(textBox2.Text, textBox3.Text);
                        setp.EnableSsl = true;
                        setp.Send(mail);
                        label2.Text = "Mail sent to their given Gmail account";
                    }
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;

            }

            Myaccountactivationpractice f2 = new Myaccountactivationpractice();
            f2.Show();
            this.Hide();

        }
    }
}
