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
    public partial class Frm_Help : Form
    {
        public Frm_Help()
        {
            InitializeComponent();
        }

        string Text;

        bool Delitel;

        int probels;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Delitel = false;
            probels = 0;

            Text = Rtb_read.Text;

            Rtb_write.Clear();

            Text = Text.Trim();//Удаляем пробелы 

            Rtb_read.Text = Text;

            Rtb_write.Text = "Длинна строки = " + Text.Length + "\n";//Вывод длинны текста


            //Чётность

            if (Text.Length % 2 == 0)
            {
                Rtb_write.Text += "Число чётное " + "\n";
            }
            else
            {
                Rtb_write.Text += "Число нечётное " + "\n";
            }

            //Чётность end

            //Делители

            Rtb_write.Text += "Делители: 1";

            for (int i = 2; i < Text.Length; i++)
            {
                if (Text.Length % i == 0)
                {
                    Delitel = true;
                    Rtb_write.Text += "," + Convert.ToString(i);
                }
            }

            Rtb_write.Text += "," + Convert.ToString(Text.Length) + "\n";

            if (Delitel == true)
            {
                Rtb_write.Text += "Число составное \n";
            }
            else
            {
                Rtb_write.Text += "Число простое \n";
            }

            //Делители end

            //Вывод кодов
            Rtb_write.Text += "\n";
            Rtb_write.Text += "///////////////\n";//Начало

            Rtb_write.Text += "\n Коды:\n\n";

            for (int i = 0; i < Text.Length; i++)
            {

                if (Text[i] == Convert.ToChar(32))
                {
                    probels++;
                    Rtb_write.Text += "Пробел" + " - " + Convert.ToString(Convert.ToInt32(Text[i])) + "\n";
                }
                else
                {
                    Rtb_write.Text += Text[i] + " - " + Convert.ToString(Convert.ToInt32(Text[i])) + "\n";
                }
            }

            Rtb_write.Text += "\n///////////////\n";//Конец
                                                    //Вывод кодов end



            //Вывод кол-ва отдельных слов или частиц
            Rtb_write.Text += "кол-во отдельных слов или частиц:" + Convert.ToString(probels + 1) + "\n";
            //Вывод кол-ва отдельных слов или частиц end
        }
    }
}
