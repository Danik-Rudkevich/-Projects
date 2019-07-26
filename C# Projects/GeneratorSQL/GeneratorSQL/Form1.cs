using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerator_Click(object sender, EventArgs e)
        {
            int kol=0,OSKOL=0;
            string buffer="",text = TbTown.Text;

            if(TbTown.Text==""||TbOS.Text==""||TbTableName.Text=="")
            {
                MessageBox.Show("Нехватка данных! \n Не сломаешь прогу так просто :)");
                return;
            }

            if(text[text.Length-1]!=' ')
            {
                text += " ";
            }

            for(int i=0;i<text.Length;i++)
            {
                if(text[i]==' ')
                {
                    kol++;
                }
            }

            string[] Name = new string[kol];

            kol = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    Name[kol] = buffer;
                    kol++;
                    buffer = "";
                }
                else
                {
                    buffer += text[i];
                }
            }

            text = TbOS.Text;
            if (text[text.Length - 1] != ' ')
            {
                text += " ";
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    OSKOL++;
                }
            }

            string[] OS = new string[OSKOL];

            OSKOL = 0;
            buffer = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    OS[OSKOL] = buffer;
                    OSKOL++;
                    buffer = "";
                }
                else
                {
                    buffer += text[i];
                }
            }

            Random rnd = new Random();

            for (int i=0;i<Convert.ToInt32(TbKol.Text);i++)
            {
                RTBOutput.Text += "\nINSERT INTO " + TbTableName.Text + " VALUES" + "(\"" + Name[rnd.Next(0, kol)] + "\"," + "\"" + OS[rnd.Next(0, OSKOL)] + "\");\n";
            }
        }

        private void RTBOutput_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(RTBOutput.Text);
            RTBOutput.Clear();
        }
    }
}
