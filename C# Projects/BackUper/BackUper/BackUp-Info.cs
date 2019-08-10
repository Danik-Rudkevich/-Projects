using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUper
{
    public partial class BackUp_Info : Form
    {
        public BackUp_Info()
        {
            InitializeComponent();
        }

        public string Returner
        {
            get { return rtbRizone.Text; }
        }

        private void BackUp_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
