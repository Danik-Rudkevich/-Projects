using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sleep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Sleep";
            notifyIcon1.BalloonTipText = "Перешло в Трэй";
            notifyIcon1.Text = "Таймер выключения";

        }

        private void PBStart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(Convert.ToInt32(textBox1.Text) * 3600 + Convert.ToInt32(textBox2.Text) * 60));
            if (Convert.ToInt32(textBox1.Text) > 0 || Convert.ToInt32(textBox2.Text) > 0)
            {
                timer1.Interval = (Convert.ToInt32(textBox1.Text) * 3600 + Convert.ToInt32(textBox2.Text) * 60) * 1000;
                timer1.Enabled = true;
                PBOk.Visible = true;
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                PB2.Visible = true;
                timer1.Interval = 100;
                timer1.Enabled = true;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C " + "ping -n 5 127.0.0.1 > NUL 2>&1 & shutdown /h /f");
            if (Convert.ToInt32(textBox1.Text) > 0 || Convert.ToInt32(textBox2.Text) > 0)
            {
                            timer1.Enabled = false;
            Application.Exit();
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
