using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тренировка_памяти
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;
        public Label lbl,lbl2;
        public bool Check = false;

        int[,] Mass = new int[4,12];

        private void lbl00_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl00;
                lbl.Text = Mass[0, 0].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl00;
                lbl2.Text = Mass[0, 0].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl01_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl01;
                lbl.Text = Mass[0, 1].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl01;
                lbl2.Text = Mass[0, 1].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl02_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl02;
                lbl.Text = Mass[0, 2].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl02;
                lbl2.Text = Mass[0, 2].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl03_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl03;
                lbl.Text = Mass[0, 3].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl03;
                lbl2.Text = Mass[0, 3].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl04_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl04;
                lbl.Text = Mass[0, 4].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl04;
                lbl2.Text = Mass[0, 4].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl05_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl05;
                lbl.Text = Mass[0, 5].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl05;
                lbl2.Text = Mass[0, 5].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl06_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl06;
                lbl.Text = Mass[0, 6].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl06;
                lbl2.Text = Mass[0, 6].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl07_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl07;
                lbl.Text = Mass[0, 7].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl07;
                lbl2.Text = Mass[0, 7].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl08_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl08;
                lbl.Text = Mass[0, 8].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl08;
                lbl2.Text = Mass[0, 8].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl09_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl09;
                lbl.Text = Mass[0, 9].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl09;
                lbl2.Text = Mass[0, 9].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl010_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl010;
                lbl.Text = Mass[0, 10].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl010;
                lbl2.Text = Mass[0, 10].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl011_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl011;
                lbl.Text = Mass[0, 11].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl011;
                lbl2.Text = Mass[0, 11].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl10_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl10;
                lbl.Text = Mass[1, 0].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl10;
                lbl2.Text = Mass[1, 0].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl11_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl11;
                lbl.Text = Mass[1, 1].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl11;
                lbl2.Text = Mass[1, 1].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl12_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl12;
                lbl.Text = Mass[1, 2].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl12;
                lbl2.Text = Mass[1, 2].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl13_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl13;
                lbl.Text = Mass[1, 3].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl13;
                lbl2.Text = Mass[1, 3].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl14_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl14;
                lbl.Text = Mass[1, 4].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl14;
                lbl2.Text = Mass[1, 4].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl15_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl15;
                lbl.Text = Mass[1, 5].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl15;
                lbl2.Text = Mass[1, 5].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl16_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl16;
                lbl.Text = Mass[1, 6].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl16;
                lbl2.Text = Mass[1, 6].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl17_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl17;
                lbl.Text = Mass[1, 7].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl17;
                lbl2.Text = Mass[1, 7].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl18_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl18;
                lbl.Text = Mass[1, 8].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl18;
                lbl2.Text = Mass[1, 8].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl19_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl19;
                lbl.Text = Mass[1, 9].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl19;
                lbl2.Text = Mass[1, 9].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl110_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl110;
                lbl.Text = Mass[1, 10].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl110;
                lbl2.Text = Mass[1, 10].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl111_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl111;
                lbl.Text = Mass[1, 11].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl111;
                lbl2.Text = Mass[1, 11].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl20_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl20;
                lbl.Text = Mass[2, 0].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl20;
                lbl2.Text = Mass[2, 0].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl21_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl21;
                lbl.Text = Mass[2, 1].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl21;
                lbl2.Text = Mass[2, 1].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl22_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl22;
                lbl.Text = Mass[2, 2].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl22;
                lbl2.Text = Mass[2, 2].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl23_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl23;
                lbl.Text = Mass[2, 3].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl23;
                lbl2.Text = Mass[2, 3].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl24_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl24;
                lbl.Text = Mass[2, 4].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl24;
                lbl2.Text = Mass[2, 4].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl25_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl25;
                lbl.Text = Mass[2, 5].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl25;
                lbl2.Text = Mass[2, 5].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl26_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl26;
                lbl.Text = Mass[2, 6].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl26;
                lbl2.Text = Mass[2, 6].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl27_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl27;
                lbl.Text = Mass[2, 7].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl27;
                lbl2.Text = Mass[2, 7].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl28_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl28;
                lbl.Text = Mass[2, 8].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl28;
                lbl2.Text = Mass[2, 8].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl29_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl29;
                lbl.Text = Mass[2, 9].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl29;
                lbl2.Text = Mass[2, 9].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl210_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl210;
                lbl.Text = Mass[2, 10].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl210;
                lbl2.Text = Mass[2, 10].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl211_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl211;
                lbl.Text = Mass[2, 11].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl211;
                lbl2.Text = Mass[2, 11].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl30_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl30;
                lbl.Text = Mass[3, 0].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl30;
                lbl2.Text = Mass[3, 0].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl31_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl31;
                lbl.Text = Mass[3, 1].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl31;
                lbl2.Text = Mass[3, 1].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl32_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl32;
                lbl.Text = Mass[3, 2].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl32;
                lbl2.Text = Mass[3, 2].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl33_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl33;
                lbl.Text = Mass[3, 3].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl33;
                lbl2.Text = Mass[3, 3].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl34_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl34;
                lbl.Text = Mass[3, 4].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl34;
                lbl2.Text = Mass[3, 4].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl35_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl35;
                lbl.Text = Mass[3, 5].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl35;
                lbl2.Text = Mass[3, 5].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl36_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl36;
                lbl.Text = Mass[3, 6].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl36;
                lbl2.Text = Mass[3, 6].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl37_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl37;
                lbl.Text = Mass[3, 7].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl37;
                lbl2.Text = Mass[3, 7].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl38_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl38;
                lbl.Text = Mass[3, 8].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl38;
                lbl2.Text = Mass[3, 8].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl39_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl39;
                lbl.Text = Mass[3, 9].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl39;
                lbl2.Text = Mass[3, 9].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl310_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl310;
                lbl.Text = Mass[3, 10].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl310;
                lbl2.Text = Mass[3, 10].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }

        private void lbl311_Click(object sender, EventArgs e)
        {

            if (!Check)
            {
                lbl = lbl311;
                lbl.Text = Mass[3, 11].ToString();
                Check = true;
                return;
            }


            if (Check)
            {
                lbl2 = lbl311;
                lbl2.Text = Mass[3, 11].ToString();
                Check = false;
                this.Enabled = false;
                TmTimer.Enabled = true;
                return;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int kol = 0,number,x,y;


            while(kol!=48)
            {
                number = rnd.Next(1, 90);
                x= rnd.Next(0, 4);
                y = rnd.Next(0, 12);

                while (Mass[x,y]!=0)
                {
                    x = rnd.Next(0, 4);
                    y = rnd.Next(0, 12);
                }

                Mass[x, y] = number;
                kol++;

                x = rnd.Next(0, 4);
                y = rnd.Next(0, 12);

                while (Mass[x, y] != 0)
                {
                    x = rnd.Next(0, 4);
                    y = rnd.Next(0, 12);
                }

                Mass[x, y] = number;
                kol++;

            }

            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar =='s')
            {
               
                lbl00.Text = Mass[0, 0].ToString();
                lbl01.Text = Mass[0, 1].ToString();
                lbl02.Text = Mass[0, 2].ToString();
                lbl03.Text = Mass[0, 3].ToString();
                lbl04.Text = Mass[0, 4].ToString();
                lbl05.Text = Mass[0, 5].ToString();
                lbl06.Text = Mass[0, 6].ToString();
                lbl07.Text = Mass[0, 7].ToString();
                lbl08.Text = Mass[0, 8].ToString();
                lbl09.Text = Mass[0, 9].ToString();
                lbl010.Text = Mass[0, 10].ToString();
                lbl011.Text = Mass[0, 11].ToString();
                lbl10.Text = Mass[1, 0].ToString();
                lbl11.Text = Mass[1, 1].ToString();
                lbl12.Text = Mass[1, 2].ToString();
                lbl13.Text = Mass[1, 3].ToString();
                lbl14.Text = Mass[1, 4].ToString();
                lbl15.Text = Mass[1, 5].ToString();
                lbl16.Text = Mass[1, 6].ToString();
                lbl17.Text = Mass[1, 7].ToString();
                lbl18.Text = Mass[1, 8].ToString();
                lbl19.Text = Mass[1, 9].ToString();
                lbl110.Text = Mass[1, 10].ToString();
                lbl111.Text = Mass[1, 11].ToString();
                lbl20.Text = Mass[2, 0].ToString();
                lbl21.Text = Mass[2, 1].ToString();
                lbl22.Text = Mass[2, 2].ToString();
                lbl23.Text = Mass[2, 3].ToString();
                lbl24.Text = Mass[2, 4].ToString();
                lbl25.Text = Mass[2, 5].ToString();
                lbl26.Text = Mass[2, 6].ToString();
                lbl27.Text = Mass[2, 7].ToString();
                lbl28.Text = Mass[2, 8].ToString();
                lbl29.Text = Mass[2, 9].ToString();
                lbl210.Text = Mass[2, 10].ToString();
                lbl211.Text = Mass[2, 11].ToString();
                lbl30.Text = Mass[3, 0].ToString();
                lbl31.Text = Mass[3, 1].ToString();
                lbl32.Text = Mass[3, 2].ToString();
                lbl33.Text = Mass[3, 3].ToString();
                lbl34.Text = Mass[3, 4].ToString();
                lbl35.Text = Mass[3, 5].ToString();
                lbl36.Text = Mass[3, 6].ToString();
                lbl37.Text = Mass[3, 7].ToString();
                lbl38.Text = Mass[3, 8].ToString();
                lbl39.Text = Mass[3, 9].ToString();
                lbl310.Text = Mass[3, 10].ToString();
                lbl311.Text = Mass[3, 11].ToString();

                MessageBox.Show("Все честно. Мне так можно :)");
            }
        }

        private void TmTimer_Tick(object sender, EventArgs e)
        {
            this.Enabled = true;
            if(lbl.Text != lbl2.Text)
            {
                lbl.Text = "?";
                lbl2.Text = "?";
            }
            else
            {
                counter += 2;
            }

            if (counter == 48)
            {
                TmTimer.Enabled = false;
                MessageBox.Show("Ого, ты выйграл!\nМолодец!!!\nА теперь я форматну твой жёсткий диск :)");
            }

            TmTimer.Enabled = false;
        }
    }
}
