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
    public partial class Glavn : Form
    {
        public Glavn()
        {
            InitializeComponent();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PBStart_Click(object sender, EventArgs e)
        {
            bool Ok = false;
            int a;

            if (TBHoura.Text == Convert.ToString(DateTime.Now.Hour) && TBMinut.Text == Convert.ToString(DateTime.Now.Minute))
            {
                a = DateTime.Now.Hour;
                if (a >=10)
                {
                    a = a / 10;
                }

                switch (a)
                { //(CB1.Checked == false && CB2.Checked == false && CB3.Checked == false && CB4.Checked == false && CB5.Checked == false && CB6.Checked == false && CB7.Checked == false && CB8.Checked == false && CB9.Checked == false && CB10.Checked == false)
                    case 0:
                        if (CB1.Checked == false && CB2.Checked == false && CB3.Checked == false && CB4.Checked == false && CB5.Checked == false && CB6.Checked == false && CB7.Checked == false && CB8.Checked == false && CB9.Checked == false && CB10.Checked == true)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                    case 1:
                        if (CB1.Checked == true && CB2.Checked == false && CB3.Checked == false && CB4.Checked == false && CB5.Checked == false && CB6.Checked == false && CB7.Checked == false && CB8.Checked == false && CB9.Checked == false && CB10.Checked == false)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                    case 2:
                        if (CB1.Checked == false && CB2.Checked == true && CB3.Checked == false && CB4.Checked == false && CB5.Checked == false && CB6.Checked == false && CB7.Checked == false && CB8.Checked == false && CB9.Checked == false && CB10.Checked == false)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                    case 3:
                        if (CB1.Checked == false && CB2.Checked == false && CB3.Checked == true && CB4.Checked == false && CB5.Checked == false && CB6.Checked == false && CB7.Checked == false && CB8.Checked == false && CB9.Checked == false && CB10.Checked == false)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                    case 4:
                        if (CB1.Checked == false && CB2.Checked == false && CB3.Checked == false && CB4.Checked == true && CB5.Checked == false && CB6.Checked == false && CB7.Checked == false && CB8.Checked == false && CB9.Checked == false && CB10.Checked == false)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                    case 5:
                        if (CB1.Checked == false && CB2.Checked == false && CB3.Checked == false && CB4.Checked == false && CB5.Checked == true && CB6.Checked == false && CB7.Checked == false && CB8.Checked == false && CB9.Checked == false && CB10.Checked == false)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                    case 6:
                        if (CB1.Checked == false && CB2.Checked == false && CB3.Checked == false && CB4.Checked == false && CB5.Checked == false && CB6.Checked == true && CB7.Checked == false && CB8.Checked == false && CB9.Checked == false && CB10.Checked == false)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                    case 7:
                        if (CB1.Checked == false && CB2.Checked == false && CB3.Checked == false && CB4.Checked == false && CB5.Checked == false && CB6.Checked == false && CB7.Checked == true && CB8.Checked == false && CB9.Checked == false && CB10.Checked == false)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                    case 8:
                        if (CB1.Checked == false && CB2.Checked == false && CB3.Checked == false && CB4.Checked == false && CB5.Checked == false && CB6.Checked == false && CB7.Checked == false && CB8.Checked == true && CB9.Checked == false && CB10.Checked == false)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                    case 9:
                        if (CB1.Checked == false && CB2.Checked == false && CB3.Checked == false && CB4.Checked == false && CB5.Checked == false && CB6.Checked == false && CB7.Checked == false && CB8.Checked == false && CB9.Checked == true && CB10.Checked == false)
                        {
                            Ok = true;
                        }
                        else
                        {
                            Ok = false;
                        }
                        break;

                }
                if (Ok == true)
                {
                    a = DateTime.Now.Minute;
                    if (a >= 10)
                    {
                        a = a / 10;
                    }
                    
                    switch (a)
                    {//(CB11.Checked == false && CB12.Checked == false && CB13.Checked == false && CB14.Checked == false && CB15.Checked == false && CB16.Checked == false && CB17.Checked == false && CB18.Checked == false && CB19.Checked == false && CB20.Checked == false)
                        case 0:
                            if (CB11.Checked == false && CB12.Checked == false && CB13.Checked == false && CB14.Checked == false && CB15.Checked == false && CB16.Checked == false && CB17.Checked == false && CB18.Checked == false && CB19.Checked == false && CB20.Checked == true)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;

                        case 1:
                            if (CB11.Checked == true && CB12.Checked == false && CB13.Checked == false && CB14.Checked == false && CB15.Checked == false && CB16.Checked == false && CB17.Checked == false && CB18.Checked == false && CB19.Checked == false && CB20.Checked == false)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;

                        case 2:
                            if (CB11.Checked == false && CB12.Checked == true && CB13.Checked == false && CB14.Checked == false && CB15.Checked == false && CB16.Checked == false && CB17.Checked == false && CB18.Checked == false && CB19.Checked == false && CB20.Checked == false)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;

                        case 3:
                            if (CB11.Checked == false && CB12.Checked == false && CB13.Checked == true && CB14.Checked == false && CB15.Checked == false && CB16.Checked == false && CB17.Checked == false && CB18.Checked == false && CB19.Checked == false && CB20.Checked == false)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;

                        case 4:
                            if (CB11.Checked == false && CB12.Checked == false && CB13.Checked == false && CB14.Checked == true && CB15.Checked == false && CB16.Checked == false && CB17.Checked == false && CB18.Checked == false && CB19.Checked == false && CB20.Checked == false)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;

                        case 5:
                            if (CB11.Checked == false && CB12.Checked == false && CB13.Checked == false && CB14.Checked == false && CB15.Checked == true && CB16.Checked == false && CB17.Checked == false && CB18.Checked == false && CB19.Checked == false && CB20.Checked == false)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;

                        case 6:
                            if (CB11.Checked == false && CB12.Checked == false && CB13.Checked == false && CB14.Checked == false && CB15.Checked == false && CB16.Checked == true && CB17.Checked == false && CB18.Checked == false && CB19.Checked == false && CB20.Checked == false)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;

                        case 7:
                            if (CB11.Checked == false && CB12.Checked == false && CB13.Checked == false && CB14.Checked == false && CB15.Checked == false && CB16.Checked == false && CB17.Checked == true && CB18.Checked == false && CB19.Checked == false && CB20.Checked == false)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;

                        case 8:
                            if (CB11.Checked == false && CB12.Checked == false && CB13.Checked == false && CB14.Checked == false && CB15.Checked == false && CB16.Checked == false && CB17.Checked == false && CB18.Checked == true && CB19.Checked == false && CB20.Checked == false)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;

                        case 9:
                            if (CB11.Checked == false && CB12.Checked == false && CB13.Checked == false && CB14.Checked == false && CB15.Checked == false && CB16.Checked == false && CB17.Checked == false && CB18.Checked == false && CB19.Checked == true && CB20.Checked == false)
                            {
                                Ok = true;
                            }
                            else
                            {
                                Ok = false;
                            }
                            break;
                    }
                }
                else { Application.Exit(); }
                
            }
            else
            {
                Application.Exit();
            }

            if (Ok == true)
            {
                Password password = new Password();
                password.Show();
                this.Hide();
                
            }
            else
            {
                Application.Exit();
            }
            



        }



        private void Glavn_Load(object sender, EventArgs e)
        {
            
            int l;
            Random rnd = new Random();
            String RNDText ="";

            for (int i =0; i < 23;i++)
            {
                 l =  rnd.Next(0,3);
                if (l==0)
                {
                    RNDText += Convert.ToChar(rnd.Next(48, 58)) ;
                }
                if (l==1)
                {
                    RNDText += Convert.ToChar(rnd.Next(97, 123));
                }
                if (l==2)
                {
                    RNDText += Convert.ToChar(rnd.Next(65, 91));
                }
                   
            }
            MessageBox.Show(RNDText);
            //MessageBox.Show(Convert.ToString(DateTime.Now.Hour));
            //MessageBox.Show(Convert.ToString(DateTime.Now.Minute));
        }
    }
}
