using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Client
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbIP.Text != "" && tbIP.Text != " " && TBPort.Text != "" && TBPort.Text != " ")
                {
                    DirectoryInfo data = new DirectoryInfo("Client_info");
                    data.Create();

                    var sw = new StreamWriter(@"Client_info/data_info.txt");
                    sw.WriteLine(tbIP.Text + ":" + TBPort.Text);
                    sw.Close();

                    this.Hide();

                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:"+ex.Message);
            }
        }
    }
}
