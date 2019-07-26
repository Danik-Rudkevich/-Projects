using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Быки_И_Коровы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Chifr = {0,1,2,3,4,5,6,7,8,9};

        int[] chifra = new int[4];

        int[] numb = new int[4];

        int n,b,k,pop;

        Random rnd = new Random();

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    n = rnd.Next(0,10);
                    if (Chifr[n] != -1)
                    {
                        numb[i] = Chifr[n];
                    }  
                } while (Chifr[n] == -1);
                Chifr[n] = -1;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.TextLength !=0)
            {
                try
                {
                chifra[textBox1.TextLength - 1] = Convert.ToInt32(Convert.ToString( textBox1.Text[textBox1.TextLength - 1]));
                }
                catch
                {
                    MessageBox.Show("Ошибка в вводе!");
                    textBox1.Text = null;
                }
           }
            
            if (textBox1.TextLength == 4)
            {
                if(textBox1.Text == "0000")
                {
                    richTextBox1.Text = "Всё честно! Не нойте :)"+"\n" ;
                    for (int i = 0; i < 4; i++)
                    { richTextBox1.Text += Convert.ToString(numb[i]); }
                }
                textBox1.Text = null;
                pop++;
                b = 0;
                k = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        if (chifra[i] == numb[y] && i==y)
                        {
                            b++;
                        }
                        else if (chifra[i] == numb[y])
                        {
                            k++;
                        }
                        
                    }
                }

                listBox1.Items.Add(Convert.ToString(chifra[0]) + Convert.ToString(chifra[1]) + Convert.ToString(chifra[2]) + Convert.ToString(chifra[3]) + " Б"+Convert.ToString(b)+","+" К"+Convert.ToString(k));
                if (b == 4)
                {
                    MessageBox.Show("Невероятно, но ты выиграл!!!"+"\n"+"Попыток:"+pop);
                }
            }
        }
    }
}
