using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginAtor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string alfavit = "qwertyuiopasdfghjklzxcvbnm";
        string alfavit2 = "DSAPOIUYTREWQMNBVCXZLKJHGF";

        string text, password,name,domen,buffer;

        private void TBWrite_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(TBWrite.Text);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        bool Ok = false;

        private void PBStart_Click(object sender, EventArgs e)
        {
            Ok = false;

            password = null;

            if (TBRead.Text != null)
            {
                text = TBRead.Text;

                for (int i=0;i<text.Length;i++)
                {
                    if (text[i] =='.')
                    {
                        name = text.Remove(i);
                        domen = text.Remove(0,i+1);
                        Ok = true;
                        break;
                    }
                }

                if (name != null && domen != null && Ok==true)
                {
                    ///////////////////////////////////////////////////
                    if (name.Length < 3)
                    {
                        for (int i = name.Length - 1; i > -1; i--)
                        {
                            password += name[i];
                        }
                    }
                    else
                    {
                        for (int i = 2; i > -1; i--)
                        {
                            password += name[i];
                        }
                    }
                    ///////////////////////////////////////////////////

                    password += Convert.ToString(Convert.ToInt32(domen[0]));

                    if (Convert.ToInt32(domen[domen.Length - 1]) < 91 && Convert.ToInt32(domen[domen.Length - 1]) > 58)
                    {
                        password += Convert.ToChar(Convert.ToInt32(domen[domen.Length - 1]) + 32);
                    }
                    else
                    {
                        password += Convert.ToChar(Convert.ToInt32(domen[domen.Length - 1]) -32 );
                    }

                    ////////////////////////////////////////////////////////

                    buffer = Convert.ToString(Convert.ToInt32(name[0]));

                    if (Convert.ToInt32(buffer[buffer.Length - 1]) % 5 == 0)
                    {
                        for (int i =0;i>buffer.Length;i++)
                        {
                            if (Convert.ToInt32(buffer[i]) % 3 == 0)
                            {
                                password += alfavit[Convert.ToInt32(buffer[i])];
                            }
                            else
                            {
                                password += alfavit2[Convert.ToInt32(buffer[i])];
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i > buffer.Length; i++)
                        {
                            if (Convert.ToInt32(buffer[i]) % 2 == 0)
                            {
                                password += alfavit2[Convert.ToInt32(buffer[i])];
                            }
                            else
                            {
                                password += alfavit[Convert.ToInt32(buffer[i])];
                            }
                        }
                    }
                    //////////////////////////////////////////////

                    password += Convert.ToString(Convert.ToInt32(name[0]) + Convert.ToInt32(domen[0]) );

                    password += alfavit2[domen.Length];

                    //////////////////////////////////////////////

                    if (password.Length % 6 == 0)
                    {
                        password += "Y";
                    }
                    else
                    {
                        password += "x";
                    }

                    ////////////////////////////////////////////////

                    password += alfavit[Convert.ToInt32(password[0])/6];

                    password += "0";

                    password += alfavit2[Convert.ToInt32(password[0])/6];

                    TBWrite.Text = password;   

                }
                else
                {
                    MessageBox.Show("Введены неправильные данные!");
                }
                
            }//Конец основного if
        }
    }
}
