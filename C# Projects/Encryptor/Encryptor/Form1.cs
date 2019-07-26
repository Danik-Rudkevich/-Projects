using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class FrmMine : Form
    {
        public FrmMine()
        {
            InitializeComponent();
        }

        string Text;

        bool Delitel;

        int probels,buff;

        private void btn_Help_Click(object sender, EventArgs e)
        {
            Frm_Help Go = new Frm_Help();
            Go.Show();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это просто кнопка и она ничего не делает :)");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            //Очистка
            RTB_Write.Clear();
            probels = 0;
            Delitel = false;
            buff = 0;
            //Очистка

            Text = RTB_Read.Text;

            for (int i = 0;i<Text.Length;i++)
            {
                RTB_Write.Text += Convert.ToString(Convert.ToInt32(Text[i])) + Text.Length;
            }

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            //Очистка
            RTB_Write.Clear();
            probels = 0;
            Delitel = false;
            buff = 1;
            //Очистка

            Text = RTB_Read.Text;

            for (int i = 2; i < Text.Length; i++)
            {
                if (Text.Length % i == 0)
                {
                    Delitel = true;
                    buff = buff * i;
                }
            }

            buff = buff * Text.Length;

            if (Delitel == false)
            {
                for (int i = 0;i<Text.Length;i++)
                {
                    RTB_Write.Text += Convert.ToString(Convert.ToInt32(Text[0]) * Text.Length);
                }
            }
            else
            {
                RTB_Write.Text += Convert.ToString(Convert.ToInt32(Text[0]) * buff);
            }

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            //Очистка
            RTB_Write.Clear();
            probels = 0;
            Delitel = false;
            buff = 0;
            //Очистка

            Text = RTB_Read.Text;

            for (int i = 2; i < Convert.ToInt32(Text[Text.Length - 1]); i++)
            {
                if (Convert.ToInt32(Text[Text.Length - 1]) % i == 0)
                {
                    Delitel = true;
                    break;
                }
            }

            if (Delitel == true)
            {

                if (Convert.ToInt32(Text[Text.Length - 1]) % 2 == 0)
                {
                    RTB_Write.Text += "Хорошо";
                }
                else
                {
                    RTB_Write.Text += "Плохо";
                }

            }
            else
            {
                RTB_Write.Text += "Интересно";
            }

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            //Очистка
            RTB_Write.Clear();
            probels = 0;
            Delitel = false;
            buff = 0;

            int min,max;
            //Очистка

            Text = RTB_Read.Text;
            min = Convert.ToInt32(Text[0]);
            max = Convert.ToInt32(Text[0]);

            for (int i=0;i<Text.Length;i++)
            {
                buff += Convert.ToInt32(Text[i]);
                if (Convert.ToInt32(Text[i]) < min)
                {
                    min = Convert.ToInt32(Text[i]);
                }
                if (Convert.ToInt32(Text[i]) > max)
                {
                    max = Convert.ToInt32(Text[i]);
                }
            }

            RTB_Write.Text += Convert.ToString(buff);
            RTB_Write.Text += Convert.ToString(max - min);
            RTB_Write.Text += Convert.ToString(max * min);
            RTB_Write.Text += Convert.ToString(max / min);
            RTB_Write.Text += Convert.ToString(max % min);

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            //Очистка
            RTB_Write.Clear();
            probels = 0;
            Delitel = false;
            buff = 0;
            //Очистка

            Text = RTB_Read.Text;

            if (Text.Length < 5)
            {
                for (int i = Text.Length-1; i > -1; i--)
                {
                    RTB_Write.Text += Convert.ToString(Convert.ToInt32(Text[i])*Text.Length) + ":)";
                }
            }
            else
            {
                if (Text.Length % 2 == 0)
                {
                    buff = Text.Length / 2;
                    for (int i = 0; i < buff; i++)
                    {
                        RTB_Write.Text += Text[i] + Text[i + buff] + Convert.ToString(Convert.ToInt32(Text[i])) + Convert.ToString(Convert.ToInt32(Text[i + buff]));
                    }
                }
                else
                {
                    RTB_Write.Text += Convert.ToString(Convert.ToInt32(Text[Text.Length/2]) * Text.Length);
                }
            }
        }
    }
}
