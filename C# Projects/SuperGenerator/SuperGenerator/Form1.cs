using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] FirstMass;
        int[] SecondMass;
        int[] RezMass;
        String[] Output;
        String[] Rand;
        int kol;
        int KolRand;
        int StringLength;
        Random rnd =new Random();

        private void Recursia(int level)
        {
            if(level==kol)
            {
                if(FirstMass[level - 1]> SecondMass[level - 1])
                {
                    for (int i = FirstMass[level - 1]; i > SecondMass[level - 1]; i--)
                    {
                        RezMass[level - 1] = i;
                        //for(int j=0;j<kol;j++)
                        //{
                        //    rtbOutput.Text += RezMass[j];
                        //}

                        for (int l = 0; l < StringLength; l++)
                        {
                            if (Output[l].IndexOf("|&") > -1)
                            {
                                if ( Output[l].IndexOf("|&0") > -1)
                                {
                                    if(KolRand < 1)
                                    {
                                        rtbOutput.Text += "\"Здесь должно было что-то вставится ,но вы не указали что\"";
                                    }
                                    else
                                    {
                                        rtbOutput.Text += Rand[rnd.Next(0, KolRand)];
                                    }      
                                }
                                else
                                {
                                    if(cbInsert.Checked)
                                    {
                                     rtbOutput.Text += Rand[Convert.ToInt32(Output[l].Substring(Output[l].IndexOf("|&") + 2, Output[l].IndexOf("&|") - 2)) - 1];   
                                    }
                                    else
                                    {
                                        rtbOutput.Text += RezMass[Convert.ToInt32(Output[l].Substring(Output[l].IndexOf("|&") + 2, Output[l].IndexOf("&|") - 2)) - 1].ToString();
                                    }             
                                }
                            }
                            else
                            {
                                rtbOutput.Text += Output[l];
                            }
                        }
                        //rtbOutput.Text += "\n___________________________________________________________\n";
                    }
                }
                else
                {
                    for (int i = FirstMass[level - 1]; i < SecondMass[level - 1]; i++)
                    {
                        RezMass[level - 1] = i;
                        //for(int j=0;j<kol;j++)
                        //{
                        //    rtbOutput.Text += RezMass[j];
                        //}

                        for (int l = 0; l < StringLength; l++)
                        {
                            if (Output[l].IndexOf("|&") > -1)
                            {
                                if (Output[l].IndexOf("|&0") > -1)
                                {
                                    if (KolRand < 1)
                                    {
                                        rtbOutput.Text += "\"Здесь должно было что-то вставится ,но вы не указали что\"";
                                    }
                                    else
                                    {
                                        rtbOutput.Text += Rand[rnd.Next(0, KolRand)];
                                    }
                                }
                                else
                                {
                                    if (cbInsert.Checked)
                                    {
                                        rtbOutput.Text += Rand[Convert.ToInt32(Output[l].Substring(Output[l].IndexOf("|&") + 2, Output[l].IndexOf("&|") - 2)) - 1];
                                    }
                                    else
                                    {
                                        rtbOutput.Text += RezMass[Convert.ToInt32(Output[l].Substring(Output[l].IndexOf("|&") + 2, Output[l].IndexOf("&|") - 2)) - 1].ToString();
                                    }
                                }
                            }
                            else
                            {
                                rtbOutput.Text += Output[l];
                            }
                        }
                       // rtbOutput.Text += "\n___________________________________________________________\n";
                    }
                }
            }
            else
            {
                if (FirstMass[level - 1] > SecondMass[level - 1])
                {
                    for (int i = FirstMass[level - 1]; i > SecondMass[level - 1]; i--)
                    {
                        RezMass[level - 1] = i;
                        Recursia(level + 1);
                    }
                }
                else
                {
                    for (int i = FirstMass[level - 1]; i < SecondMass[level - 1]; i++)
                    {
                        RezMass[level - 1] = i;
                        Recursia(level + 1);
                    }
                }
            }
        }

        private void OutputTemplate()
        {
            StringLength = 0;

            string text = rtbInput.Text;

            Output = new string[(text.Split(new string[] { "|&" }, StringSplitOptions.None).Count() - 1)*2 + 1];

            while (text.IndexOf("|&") > -1 && text.IndexOf("&|") > -1)
            {
                for(int i=0;i< text.IndexOf("|&");i++)
                {
                    Output[StringLength] += text[i];
                }
                if(text.IndexOf("|&")==0)
                {
                    StringLength--;//Кастыль
                }
                StringLength++;
                for (int i = text.IndexOf("|&"); i < text.IndexOf("&|")+2; i++)
                {
                    Output[StringLength] += text[i];
                }
                StringLength++;
                text = text.Remove(0, text.IndexOf("&|") +2);
            }

            Output[StringLength] = text;
            StringLength++;

            //for (int i = 0; i < StringLength; i++)
            //{
            //    rtbOutput.Text += Output[i] + "\n";
            //}

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tbFirstMass.Text ==""||tbSecondMass.Text=="")
            {
                return;
            }

            OutputTemplate();

            string text = tbRandom.Text;
            int kol2 = 0;
            string buffer = "";
            kol = 0;
            KolRand = 0;

            if (text != "" && text[text.Length - 1] != ' ')
            {
                text += " ";
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    KolRand++;
                }
            }

            Rand = new string[KolRand];
            KolRand = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    Rand[KolRand] = buffer;
                    KolRand++;
                    buffer = "";
                }
                else
                {
                    buffer += text[i];
                }
            }

            kol = 0;
            
            text = tbFirstMass.Text;
            

            if (text[text.Length - 1] != ' ')
            {
                text += " ";
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    kol++;
                }
            }

            FirstMass = new int[kol];
            SecondMass = new int[kol];
            RezMass = new int[kol];

            kol = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    FirstMass[kol] = Convert.ToInt32(buffer);
                    kol++;
                    buffer = "";
                }
                else
                {
                    buffer += text[i];
                }
            }

            text = tbSecondMass.Text;
            buffer = "";

            if (text[text.Length - 1] != ' ')
            {
                text += " ";
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    SecondMass[kol2] = Convert.ToInt32(buffer);
                    kol2++;
                    buffer = "";
                }
                else
                {
                    buffer += text[i];
                }
            }

            Recursia(1);

        }

        private void tbFirstMass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar!=32 && e.KeyChar!=8 && e.KeyChar!='-')
            {
                e.Handled = true;
            }
        }

        private void tbSecondMass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 32 && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void rtbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 17)
            {
                int pos = rtbInput.SelectionStart;
                rtbInput.Text = rtbInput.Text.Insert(rtbInput.SelectionStart, "|&&|");
                rtbInput.SelectionStart = pos+2;
            }
        }

        private void rtbOutput_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbOutput.Text);
            rtbOutput.Clear();
        }

        private void rtbInput_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbInput.Text);
            rtbInput.Clear();
        }
    }
}
