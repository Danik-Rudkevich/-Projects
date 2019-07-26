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

        public SimulatorKeyboard()
        {
            InitializeComponent();
        }
        public string strKey = "", strTime = "",strXStart="", strYStart = "", strXEnd = "", strYEnd = "";
        bool stop = false;

        public string[] KeyArray = new string[100];
        public string[] TimeArray = new string[100];
        public string[] startX = new string[100];
        public string[] startY = new string[100];
        public string[] endX = new string[100];
        public string[] endY = new string[100];        public int i = 0;
        public int R, G, B;

        [DllImport("User32.dll")]
        static extern void mouse_event(MouseFlags dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);

        //для удобства использования создаем перечисление с необходимыми флагами (константами), которые определяют действия мыши: 
        [Flags]
        enum MouseFlags
        {
            Move = 0x0001, LeftDown = 0x0002, LeftUp = 0x0004, RightDown = 0x0008,
            RightUp = 0x0010, Absolute = 0x8000
        };

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

        private Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
            if(!stop)
            {
                R = Convert.ToInt32(TbR.Text);
                G = Convert.ToInt32(TbG.Text);
                B = Convert.ToInt32(TbB.Text);

                strKey = tb.Text;

                strXStart = TbXStart.Text;
                strXEnd = TbEndX.Text;
                strYEnd = TbEndY.Text;
                strYStart = TbYStart.Text;

                startX = strXStart.Split(',');
                startY = strYStart.Split(',');
                endX = strXEnd.Split(',');
                endY = strYEnd.Split(',');

                KeyArray = strKey.Split(',');
                TimeArray = strTime.Split(',');

                PauseTimer.Interval = Convert.ToInt32(tbPause.Text) * 1000;
                PauseTimer.Enabled = true;
                stop = true;
                rtbLog.Text += "\nStart";
            }
            else
            {
                rtbLog.Text += "\nStop";
                stop = false;
                StartTimer.Enabled = false;
            }
            
            

        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            Color Buffer;
            bool Ok = false;
            for (int i = 0; i < endX.Length; i++)
            {
                for (int j = Convert.ToInt32(startX[i]); j < Convert.ToInt32(endX[i]); j++)
                {
                    for (int k = Convert.ToInt32(startY[i]); k < Convert.ToInt32(endY[i]); k++)
                    {
                        Buffer = GetPixelColor(j, k);
                        if (Buffer.R == R && Buffer.G == G && Buffer.B == B)
                        {
                            rtbLog.Text += "\nПроверен пиксель " + Convert.ToString(j) + ":" + Convert.ToString(k) + " -true";
                            Ok = true;
                            break;
                            
                        }
                        else
                        {
                            rtbLog.Text += "\nПроверен пиксель " + Convert.ToString(j)+":" +Convert.ToString(k) +" -false";
                        }
                    }
                    if(Ok)
                    {
                        if(KeyArray[i]=="1")
                        {
                            mouse_event(MouseFlags.Absolute | MouseFlags.Move, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.LeftDown, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.RightUp, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.Move, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.LeftDown, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.RightUp, 32000, 32000, 0, UIntPtr.Zero);
                            rtbLog.Text += "\nОбласть №" + Convert.ToString(i) + " вызвало СКМ";
                        }
                        else if(KeyArray[i] == "2")
                        {
                            mouse_event(MouseFlags.Absolute | MouseFlags.Move, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.RightDown, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.RightUp, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.Move, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.RightDown, 32000, 32000, 0, UIntPtr.Zero);
                            mouse_event(MouseFlags.Absolute | MouseFlags.RightUp, 32000, 32000, 0, UIntPtr.Zero);
                            rtbLog.Text += "\nОбласть №" + Convert.ToString(i) + " вызвало ПКМ";
                        }
                        else
                        {
                            SendKeys.Send(KeyArray[i]); SendKeys.Send(KeyArray[i]); SendKeys.Send(KeyArray[i]);
                            rtbLog.Text += "\nОбласть №" + Convert.ToString(i) + " вызвало '"+ KeyArray[i]+"'";
                        }
                        
                        break;
                    }
                }
                if (Ok)
                {
                    rtbLog.Text += "\nПроверка закончена на области №" + Convert.ToString(i);
                    break;
                }
            }
        }

        private void StopTimer_Tick(object sender, EventArgs e)
        {
            
            
            
        }
        
        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            PauseTimer.Enabled = false;
            StartTimer.Enabled = true;
            StartTimer.Interval = Convert.ToInt32(tbSpeed.Text);
        }
    }
}
