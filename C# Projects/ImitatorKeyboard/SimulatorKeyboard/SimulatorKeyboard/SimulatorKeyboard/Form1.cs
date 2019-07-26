using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing.Imaging;


namespace SimulatorKeyboard
{
    

    public partial class SimulatorKeyboard : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public SimulatorKeyboard()
        {
            InitializeComponent();
        }
        public string strKey = "", strTime = "";

        public string[] KeyArray = new string[100];
        public string[] TimeArray = new string[100];
        public int i = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Get a handle to the Calculator application. The window class
            // and window name were obtained using the Spy++ tool.
            IntPtr calculatorHandle = FindWindow("CalcFrame", "Google Chrome");
            GetPixelColor(1000, 100);
            // Verify that Calculator is a running process.
            if (calculatorHandle == IntPtr.Zero)
            {
                MessageBox.Show("Calculator is not running.");
                return;
            }
            
            // Make Calculator the foreground application and send it 
            // a set of calculations.
            SetForegroundWindow(calculatorHandle);
            SendKeys.SendWait("111");
            SendKeys.SendWait("*");
            SendKeys.SendWait("11");
            SendKeys.SendWait("=");

            /*
            strKey = tb.Text;
            strTime = tbWork.Text;


            KeyArray = strKey.Split(',');
            TimeArray = strTime.Split(',');

            i = 0;

            
            StartTimer.Interval = Convert.ToInt32(tbSpeed.Text);
            StopTimer.Interval = Convert.ToInt32(TimeArray[0]) * 1000;
            PauseTimer.Interval = Convert.ToInt32(tbPause.Text) * 1000;
            PauseTimer.Enabled = true;
            pictureBox1.Visible = false;

            i++;
            */

        }

        private void GetPixelColor(int x,int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            MessageBox.Show(Convert.ToString(color));
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void StopTimer_Tick(object sender, EventArgs e)
        {
            
            if(i<KeyArray.Length)
            {
                
                StopTimer.Interval = Convert.ToInt32(TimeArray[i]) * 1000;
                i++;
            }
            else
            {
                pictureBox1.Visible = true;
                StartTimer.Enabled = false;
                StopTimer.Enabled = false;
            }
            
        }

        private void SimulatorKeyboard_Load(object sender, EventArgs e)
        {
            GetPixelColor(1000, 100);
        }

        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            StopTimer.Enabled = true;
            StartTimer.Enabled = true;
            PauseTimer.Enabled = false;
        }
    }
}
