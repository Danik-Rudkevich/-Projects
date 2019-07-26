using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImitatorKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i=0;

        private void button1_Click(object sender, EventArgs e)
        {           
            i = 1;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("w");
            i++;
            if(i==30)
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(i==1)
            {
                timer1.Enabled = true;
            }
            if(i==0)
            {
                timer3.Enabled = true;
            }
            timer2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            timer2.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("w");
            i++;
            if (i == 1000)
            {
                timer3.Enabled = false;
            }
        }
    }
}
