using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string kod = Los.Losowanie().ToString();
        public Form1()
        {
            InitializeComponent();
            pokazOknologowania();
        }

        private void pokazOknologowania()
        {
            log1.Visible = true;
            log2.Visible = false;
            log3.Visible = false;
            if (nierobot.Checked == true)
            {
                robot.Checked = false;
            }
            else if (robot.Checked == true)
            {
                nierobot.Checked = false;
            }
        }

        private void weryfikuj_Click(object sender, EventArgs e)
        {
            if (login.Text == "admin" && haslo.Text == "admin" && nierobot.Checked == true)
            {
                MessageBox.Show("zalogowales sie");
                log1.Visible = false;
                log2.Visible = true;
            }
            else
            {
                MessageBox.Show("Błędnie wprowadzone dane");
            }
        }
        private void wyslij_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("kodwerc@gmail.com");
                mail.To.Add(email.Text);
                mail.Subject = "Kod weryfikacyjny";
                mail.Body = kod;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("kodwerc", "zaq1@WSXzaq1");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("E-mail został wysłany");
                log3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sprawdz_Click(object sender, EventArgs e)
        {
            if (sprawdzenie.Text.Equals(kod))
            {
                MessageBox.Show("Zalogowałeś się poprawnie!!");
                log2.Visible = false;
                log3.Visible = false;
            }
            else
            {
                MessageBox.Show("Kod jest niepoprawny.Spróbuj jeszcze raz");
            }
        }
    }
}
